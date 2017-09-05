using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using GPSSGenerator.Nodes;
using GPSSGenerator.Nodes.Transfers;
using GPSSGenerator.Nodes.Generators;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.DTO;

namespace GPSSGenerator.StreamDimension
{
	class StreamModel
	{
		private StreamNode root;
		private string id;

		public string Id
		{
			get
			{
				return id;
			}
		}

		public StreamNode Root
		{
			get
			{
				return root;
			}

			set
			{
				root = value;
			}
		}

		public StreamModel(string id, Node[] originalNodes, float[,] graph, ContainerForBeforAfterStatistic[] beforAfterStatistics)
		{
			this.id = id;

			AnalizeAndBuildStreamNodes(originalNodes, graph, beforAfterStatistics);
		}

		public List<string> buildStreamDescription()
		{
			return buildStreamDescriptionRec(root);
		}

		private List<string> buildStreamDescriptionRec(StreamNode node)
		{
			List<string> description = node.buildDescription(id);

			description[0] = string.Format("{0}\t{1}", node.IsNeedLabel? node.Label : "\t", description[0]);

			for(int i =1;i< description.Count; i++)
			{
				description[i] = "\t\t" + description[i];
			}

			for (int i = 0; i < node.NextNodes.Count; i++)
			{
				description.AddRange(buildStreamDescriptionRec(node.NextNodes[i]));
			}
			
			return description;
		}

		private void AnalizeAndBuildStreamNodes(Node[] originalNodes, float[,] graph, ContainerForBeforAfterStatistic[] beforAfterStatistics)
		{
			if (graph.GetLength(0) != graph.GetLength(1))
			{
				throw new Exception("graph is not square!");
			}

			if (originalNodes.Length != graph.GetLength(0))
			{
				throw new Exception("graph size and namber of original nodes is not identical!");
			}

			for (int i = 0; i < graph.GetLength(0); i++)
			{
				float counter = 0;
				for (int j = 0; j < graph.GetLength(1); j++)
				{
					counter += graph[i, j];
				}
				if (counter != 1 && counter != 0)
					throw new Exception(string.Format("Line {0} is wrong in matrix!", i + 1));
			}

			int startNode = -1;

			for (int i = 0; i < originalNodes.Length; i++)
			{
				if ((originalNodes[i] is OpenGenerator) || (originalNodes[i] is ClosedGenerator))
				{
					startNode = i;
					break;
				}
			}

			if (startNode == -1)
			{
				throw new Exception("can't build stream, there isn't any generator!");
			}

			StreamNode[] streamNodes = new StreamNode[originalNodes.Length];

			BuildRoot(startNode, originalNodes, streamNodes, graph);

			InjectStatisticsInStreamNodes(streamNodes, beforAfterStatistics);
		}

		private void BuildRoot(
			int pos, 
			Node[] originalNodes, 
			StreamNode[] streamNodes, 
			float[,] graph)
		{
			root = new StreamNode(originalNodes[pos], "");

			streamNodes[pos] = root;

			for (int i = 0; i < originalNodes.Length; i++)
			{
				if (graph[pos, i] == 1f)
				{
					root.NextNodes.Add(BuildStreamNode(i, originalNodes, streamNodes, graph));
				}
				else if ((graph[pos, i] < 1f) && (graph[pos, i] > 0f))
				{
					root.NextNodes.Add(BuildTransfer(pos, originalNodes, streamNodes, graph));
					break;
				}
			}

		}

		private StreamNode BuildStreamNode(
			int pos, 
			Node[] originalNodes,
			StreamNode[] streamNodes,
			float[,] graph)
		{
			streamNodes[pos] = new StreamNode(originalNodes[pos], string.Format("label_{0}_{1}", originalNodes[pos].Id, id));

			for (int i = 0; i < originalNodes.Length; i++)
			{
				if (graph[pos, i] == 1f)
				{
					if (streamNodes[i] != null)
					{
						streamNodes[pos].NextNodes.Add(BuildAbsoluteTransfer(pos, originalNodes, streamNodes, graph));
					}
					else
					{
						streamNodes[pos].NextNodes.Add(BuildStreamNode(i, originalNodes, streamNodes, graph));
					}
				}
				else if ((graph[pos, i] < 1f) && (graph[pos, i] > 0f))
				{
					streamNodes[pos].NextNodes.Add(BuildTransfer(pos, originalNodes, streamNodes, graph));
					break;
				}
			}

			return streamNodes[pos];
		}

		private StreamNode BuildTransfer(
			int pos, 
			Node[] originalNodes,
			StreamNode[] streamNodes,
			float[,] graph)
		{
			List<float> probabilities = new List<float>();
			List<StreamNode> nodesInTree = new List<StreamNode>();
			List<StreamNode> nodesInTransfer = new List<StreamNode>();
			for (int i = 0; i < originalNodes.Length; i++)
			{
				if (graph[pos, i] > 0f)
				{
					probabilities.Add(graph[pos, i]);
					if (streamNodes[i] != null)
					{
						streamNodes[i].IsNeedLabel = true;
						nodesInTransfer.Add(streamNodes[i]);
					}
					else
					{
						StreamNode tmp = BuildStreamNode(i, originalNodes, streamNodes, graph);
						tmp.IsNeedLabel = true;
						nodesInTree.Add(tmp);
						nodesInTransfer.Add(tmp);
					}
				}
			}


			Transfer transfer = new Transfer(
				string.Format("t_{0}", GlobalVariables.counterOfTransfers++),
				probabilities,
				nodesInTransfer);

			StreamNode node = new StreamNode(transfer, string.Format("label_{0}_{1}", transfer.Id, id));
			node.NextNodes.AddRange(nodesInTree);
			return node;
		}

		private StreamNode BuildAbsoluteTransfer(
			int pos,
			Node[] originalNodes,
			StreamNode[] streamNodes,
			float[,] graph)
		{
			List<float> probabilities = new List<float>();
			List<StreamNode> nodes = new List<StreamNode>();
			for (int i = 0; i < originalNodes.Length; i++)
			{
				if (graph[pos, i] == 1f)
				{
					probabilities.Add(graph[pos, i]);
					streamNodes[i].IsNeedLabel = true;
					nodes.Add(streamNodes[i]);
					break;
				}
			}


			Transfer transfer = new Transfer(
				string.Format("t_{0}", GlobalVariables.counterOfTransfers++),
				probabilities,
				nodes);

			StreamNode node = new StreamNode(transfer, string.Format("label_{0}_{1}", transfer.Id, id));
			return node;
		}

		private void InjectStatisticsInStreamNodes(StreamNode[] streamNodes, ContainerForBeforAfterStatistic[] beforAfterStatistics)
		{
			for (int i = 0; i < streamNodes.Length; i++) 
			{
				for (int j = 0; j < beforAfterStatistics.Length; j++) 
				{
					if(streamNodes[i].Node.Id == beforAfterStatistics[j].Node.Id)
					{
						streamNodes[i].AfterStatistic = beforAfterStatistics[j].After;
						streamNodes[i].BeforeStatistic = beforAfterStatistics[j].Before;
					}
				}
			}
		}
		
	}
}
