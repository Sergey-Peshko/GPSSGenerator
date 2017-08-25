using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.Nodes;
using GPSSGenerator.StreamDimension;
using System.IO;

namespace ConsoleInterface
{
	class ModelReader
	{
		public static GlobalModel Read(string path)
		{
			GlobalModel model = new GlobalModel();

			StreamReader sr = new StreamReader(path);

			string type = sr.ReadLine();
			if (type == "Time")
			{
				model.Settings.IsTime = true;
				model.Settings.AmountOfTime = Convert.ToInt32(sr.ReadLine());
			}
			else if(type == "Transactions")
			{
				model.Settings.IsTrainsactions = true;
				model.Settings.NumberOfTransactions = Convert.ToInt32(sr.ReadLine());
			}

			int numberOfNodes = Convert.ToInt32(sr.ReadLine());

			string[][] nodesDesciption = new string[numberOfNodes][];

			for (int i = 0; i < numberOfNodes; i++)
			{
				string tmp = sr.ReadLine();
				string[] tmpMass = tmp.Split(' ');
				nodesDesciption[i] = (tmpMass);
			}

			model.Nodes = NodeFactory.CreateNodes(nodesDesciption);

			int count = Convert.ToInt32(sr.ReadLine());
			model.StreamModels = new StreamModel[count];

			for (int k = 0; k < count; k++)
			{

				int numberOfStreamNodes = Convert.ToInt32(sr.ReadLine());
				Node[] nodes = new Node[numberOfStreamNodes];

				string nodesInexes = sr.ReadLine();
				string[] nodesInexesMass = nodesInexes.Split(' ');
				for (int i = 0; i < numberOfStreamNodes; i++)
				{
					nodes[i] = (Node)model.Nodes[Convert.ToInt32(nodesInexesMass[i])];
				}

				float[,] graph = new float[numberOfStreamNodes, numberOfStreamNodes];
				for (int i = 0; i < numberOfStreamNodes; i++)
				{
					string tmp = sr.ReadLine();
					string[] mass = tmp.Split(' ');
					for (int j = 0; j < numberOfStreamNodes; j++)
					{
						graph[i, j] = (float)(Convert.ToDouble(mass[j]));
					}
				}
		
				model.StreamModels[k] = new StreamModel(
					k,
					nodes,
					graph);
			}

			return model;
		}
	}
}
