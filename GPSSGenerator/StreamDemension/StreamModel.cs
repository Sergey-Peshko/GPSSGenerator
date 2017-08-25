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

namespace GPSSGenerator.StreamDimension
{
	public class StreamModel
	{
		private StreamNode root;
		private int index;

		public int Index
		{
			get
			{
				return index;
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

		public StreamModel(int index, Node[] originalNodes, float[,] graph)
		{
			this.index = index;

			AnalizeAndBuildStreamNodes(originalNodes, graph);
		}

		public List<string> buildStreamDescription()
		{

		}

		public List<string> buildStreamDescriptionRec()
		{

		}

		public void Show()
		{
			ShowRec(root);
		}

		private void ShowRec(StreamNode node)
		{
			Console.WriteLine(node.Node.Id);
			for(int i = 0; i < node.NextNodes.Count; i++)
			{
				ShowRec(node.NextNodes[i]);
			}
		}

		private void AnalizeAndBuildStreamNodes(Node[] originalNodes, float[,] graph)
		{
			if (graph.GetLength(0) != graph.GetLength(1))
			{
				throw new Exception("graph is not square!");
			}

			if (originalNodes.Length != graph.Length)
			{
				throw new Exception("graph size and namber of original nodes is not identical!");
			}

			for (int i = 0; i < graph.Length; i++)
			{
				float counter = 0;
				for (int j = 0; j < graph.Length; j++)
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

			BuildRoot(startNode, originalNodes, new StreamNode[originalNodes.Length], graph);
		}

		private void BuildRoot(
			int pos, 
			Node[] originalNodes, 
			StreamNode[] streamNodes, 
			float[,] graph)
		{
			root = new StreamNode(originalNodes[pos], "");

			for (int i = 0; i < originalNodes.Length; i++)
			{
				if (graph[pos, i] == 1f)
				{
					root.NextNodes.Add(BuildStreamNode(i, originalNodes, streamNodes, graph));
				}
				else if ((graph[pos, i] < 1f) && (graph[pos, i] > 0f))
				{
					root.NextNodes.Add(BuildTransfer(pos, originalNodes, streamNodes, graph));
				}
			}

		}

		private StreamNode BuildStreamNode(
			int pos, 
			Node[] originalNodes,
			StreamNode[] streamNodes,
			float[,] graph)
		{
			streamNodes[pos] = new StreamNode(originalNodes[pos], string.Format("label_{0}_{1}", originalNodes[pos].Id, index));

			for (int i = 0; i < originalNodes.Length; i++)
			{
				if (graph[pos, i] == 1f)
				{
					if(streamNodes[i] != null)
					{
						streamNodes[pos].NextNodes.Add(BuildAbsoluteTransfer(pos, originalNodes, streamNodes, graph));
					}
					streamNodes[pos].NextNodes.Add(BuildStreamNode(i, originalNodes, streamNodes, graph));
				}
				else if ((graph[pos, i] < 1f) && (graph[pos, i] > 0f))
				{
					streamNodes[pos].NextNodes.Add(BuildTransfer(pos, originalNodes, streamNodes, graph));
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
			List<StreamNode> nodes = new List<StreamNode>();
			for (int i = 0; i < originalNodes.Length; i++)
			{
				if (graph[pos, i] > 0f)
				{
					probabilities.Add(graph[pos, i]);
					if (streamNodes[i] != null)
					{
						streamNodes[i].IsNeedLabel = true;
						nodes.Add(streamNodes[i]);
					}
					else
					{
						StreamNode tmp = BuildStreamNode(i, originalNodes, streamNodes, graph);
						tmp.IsNeedLabel = true;
						nodes.Add(tmp);
					}
				}
			}


			Transfer transfer = new Transfer(
				string.Format("t_{0}", GlobalVariables.counterOfTransfers),
				probabilities,
				nodes);

			StreamNode node = new StreamNode(transfer, string.Format("label_{0}_{1}", transfer.Id, index));
			node.NextNodes.AddRange(nodes);
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
				string.Format("t_{0}", GlobalVariables.counterOfTransfers),
				probabilities,
				nodes);

			StreamNode node = new StreamNode(transfer, string.Format("label_{0}_{1}", transfer.Id, index));
			return node;
		}
	}
}
