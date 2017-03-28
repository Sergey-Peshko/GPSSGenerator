using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace GPSSGenerator
{
	class StreamModel
	{
		private List<List<double>> graph;
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

		public List<List<double>> Graph
		{
			get
			{
				return graph;
			}
		}

		public List<INode> Nodes
		{
			get
			{
				return nodes;
			}
		}
		public StreamModel(int index)
		{
			this.index = index;
		}
		public void Read(ref StreamReader sr, List<INode> sourseList)
		{
			int numberOfNodes = Convert.ToInt32(sr.ReadLine());
			nodes = new List<INode>();

			string nodesInexes = sr.ReadLine();
			string[] nodesInexesMass = nodesInexes.Split(' ');
			for(int i=0;i< numberOfNodes;i++)
			{
				nodes.Add(sourseList[Convert.ToInt32(nodesInexesMass[i])]);
			}

			graph = new List<List<double>>();
			for (int i = 0; i < numberOfNodes; i++)
			{
				string tmp = sr.ReadLine();
				string[] mass = tmp.Split(' ');
				List<double> links = new List<double>();
				for (int j = 0; j < numberOfNodes; j++)
				{
					links.Add(Convert.ToDouble(mass[j]));
				}
				graph.Add(links);
			}

			AnalisOfMatrx();
		}
		public void Show()
		{
			for (int i = 0; i < nodes.Count; i++)
			{
				Console.WriteLine("{0}\t{1}", i + 1, nodes[i].Name);
			}
			for (int i = 0; i < nodes.Count; i++)
			{
				Console.WriteLine();
				for (int j = 0; j < nodes.Count; j++)
				{
					Console.Write("{0}\t", graph[i][j]);
				}
			}
			Console.WriteLine();
		}
		private void AnalisOfMatrx()
		{
			for (int i = 0; i < graph.Count; i++)
			{
				double counter = 0;
				for (int j = 0; j < graph[i].Count; j++)
				{
					counter += graph[i][j];
				}
				if (counter > 2 && counter != 0)
					throw new Exception("Matrix wrong");
			}
		}
	}
}
