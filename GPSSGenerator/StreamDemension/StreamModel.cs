using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using GPSSGenerator.Nodes;
using GPSSGenerator.Nodes.Nodes;
using GPSSGenerator.GlobalDimension;

namespace GPSSGenerator.StreamDimension
{
	public class StreamModel
	{
		private List<INode> nodes;
		private int index;

		public int Index
		{
			get
			{
				return index;
			}
		}

		public int NumberOfNodes
		{
			get
			{
				return nodes.Count;
			}
		}

		public List<INode> Nodes
		{
			get
			{
				return nodes;
			}
		}
		public StreamModel(int index, INode[] originalNodes, float[,] graph)
		{
			this.index = index;

			if (graph.GetLength(0) != graph.GetLength(1))
			{
				throw new Exception("graph is not square!");
			}

			if(originalNodes.Length != graph.Length)
			{
				throw new Exception("graph size and namber of original nodes is not identical!");
			}

			BuildStreamNodes(originalNodes, graph);
		}
		
		public void Show()
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				Console.WriteLine("{0}.\t{1}", i + 1, nodes[i].Id);
				Console.WriteLine("next: ");
				for (int j = 0; j < nodes[i].NextNodes.Count; j++)
				{
					Console.Write("{0}.\t{1}", j + 1, nodes[i].NextNodes[j].Id);
				}
			}
		}
		private void BuildStreamNodes(INode[] originalNodes, float[,] graph)
		{
			nodes = new List<INode>();

		}
		private void AnalisOfMatrix(float[][] graph)
		{
			for (int i = 0; i < graph.Count; i++)
			{
				double counter = 0;
				for (int j = 0; j < graph[i].Count; j++)
				{
					counter += graph[i][j];
				}
				if (counter != 1 && counter != 0)
					throw new Exception("Matrix wrong");
			}

			int count = graph.Count;
			for (int i = 0; i < count; i++)
			{
				for (int j = 0; j < count; j++)
				{
					if(graph[i][j] < 1 && graph[i][j] > 0)
					{
						InsertTransfers(i);
						break;
					}
				}
			}
		}

		private int InsertTransfers(int currNode)
		{
			List<KeyValuePair<int, double>> transitions = new List<KeyValuePair<int, double>>();
			for (int i = 0; i < graph[currNode].Count; i++)
			{
				if (graph[currNode][i] > 0 && graph[currNode][i] < 1)
				{
					transitions.Add(new KeyValuePair<int, double>(i, graph[currNode][i]));
					nodes[i].IsNeedLabel = true;
				}
			}
			double remainingPersents = 1;
			Transfer[] transfers = new Transfer[transitions.Count - 1];
			for (int i = 0; i < transfers.Length; i++)
			{
				transfers[i] = new Transfer(string.Format("t{0}", GlobalVariables.counterOfTransfers++));
				if (i > 0)
					transfers[i].IsNeedLabel = true;
			}
			List<List<double>> insertlinks = new List<List<double>>();
			for (int i = 0; i < transitions.Count - 1; i++)
			{
				double percents = (double)(transitions[i].Value * 1) / remainingPersents;
				remainingPersents -= transitions[i].Value;
				
				transfers[i].Probability1 = percents;
				transfers[i].Node1 = nodes[transitions[i].Key];
				if(i == transitions.Count - 2)
				{
					transfers[i].Node2 = nodes[transitions[transitions.Count - 1].Key];
				}
				else
				{
					transfers[i].Node2 = transfers[i + 1];
				}

				List<double> tmp = new List<double>();

				for (int ii = 0; ii < (graph.Count + transitions.Count - 1); ii++)
				{
					tmp.Add(0);
				}
				tmp[transitions[i].Key] = percents;
				tmp[i == transitions.Count - 2 ?
					transitions[transitions.Count - 1].Key :
					transitions[i].Key + 1] = 1 - percents;


				insertlinks.Add(tmp);

			}

			for (int i = 0; i < graph.Count; i++)
			{
				graph[i].InsertRange(graph.Count, new double[transitions.Count - 1]);
			}

			for (int i = 0; i < graph[currNode].Count; i++)
			{
				graph[currNode][i] = 0;
			}

			graph[currNode][graph.Count] = 1;

			nodes.InsertRange(nodes.Count, transfers);
			graph.InsertRange(graph.Count, insertlinks);

			return transfers.Length;
		}
	}
}
