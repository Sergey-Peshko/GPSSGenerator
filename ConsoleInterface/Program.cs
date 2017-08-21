using System;
using System.Collections.Generic;
using System.IO;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.Nodes;
using GPSSGenerator.StreamDimension;

namespace ConsoleInterface
{
	class Program
	{
		public static string data = "C:\\Users\\peshk\\Documents\\Visual Studio 2015\\Projects\\GPSSGenerator\\GPSSGenerator\\data\\";
		public static string rez = "C:\\Users\\peshk\\Documents\\Visual Studio 2015\\Projects\\GPSSGenerator\\GPSSGenerator\\rez\\";

		static void Main(string[] args)
		{
			Console.Write("input file name: ");
			string path = Console.ReadLine();
			GlobalModel gl = Read(data + path);
			gl.MakeCode();
		}

		static GlobalModel Read(string path)
		{
			GlobalModel globalModel = new GlobalModel();

			StreamReader sr = new StreamReader(path);
			int numberOfNodes = Convert.ToInt32(sr.ReadLine());

			globalModel.Nodes = new List<INode>(numberOfNodes);
			string[][] nodesDesciption = new string[numberOfNodes][];

			for (int i = 0; i < numberOfNodes; i++)
			{
				string tmp = sr.ReadLine();
				string[] tmpMass = tmp.Split(' ');
				nodesDesciption[i] = (tmpMass);
			}

			globalModel.nodes = NodeFactory.CreateNodes(nodesDesciption);

			int count = Convert.ToInt32(sr.ReadLine());
			matrixs = new StreamModel[count];

			for (int i = 0; i < count; i++)
			{
				matrixs[i] = new StreamModel(i);
				matrixs[i].Read(ref sr, nodes);
			}
		}

		public void Read(ref StreamReader sr, List<INode> sourseList)
		{
			int numberOfNodes = Convert.ToInt32(sr.ReadLine());
			nodes = new List<INode>();

			string nodesInexes = sr.ReadLine();
			string[] nodesInexesMass = nodesInexes.Split(' ');
			for (int i = 0; i < numberOfNodes; i++)
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

			AnalisOfMatrix();
		}
	}
}
