﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.Nodes;
using GPSSGenerator.StreamDimension;
using System.IO;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Facilities;
using GPSSGenerator.Nodes.Generators;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.Nodes.Terminates;
using GPSSGenerator.Nodes.Transfers;
using GPSSGenerator.Nodes;

namespace GPSSGenerator.ModelReaders
{
	public static class TxtModelReader
	{
		static public GlobalModel Read(string path)
		{
			GlobalModel model = new GlobalModel();

			StreamReader sr = new StreamReader(path);

			string type = sr.ReadLine();
			if (type == "Time")
			{
				model.Settings.AmountOfTime = Convert.ToInt32(sr.ReadLine());
			}
			else if(type == "Transactions")
			{
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

			model.Nodes = CreateNodes(nodesDesciption);

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
					Convert.ToString(k),
					nodes,
					graph);
			}

			return model;
		}

		static private Entity[] CreateNodes(string[][] nodes)
		{
			IntervalStatistic netLevel = new IntervalStatistic("net_stat", "net");

			Entity[] rezult = new Entity[nodes.Length];
			for (int i = 0; i < nodes.Length; i++)
			{
				rezult[i] = CreateNode(nodes[i], netLevel);
			}
			return rezult;
		}

		static private Entity CreateNode(string[] param, IntervalStatistic netLevel)
		{
			if (param[0] == "RECEIVER")
			{
				Terminate entity = new Terminate(param[1],
					Convert.ToInt32(param[2]),
					netLevel);

				return entity;
			}
			else if (param[0] == "GENERATOR")
			{
				string[] distributionParam = new string[param.Length - 2];
				Array.Copy(param, 2, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = CreateDistribution(distributionParam);
				return new OpenGenerator(param[1], netLevel, distribution); ;
			}
			else if (param[0] == "ZGENERATOR")
			{
				return new ClosedGenerator(param[1], netLevel, Convert.ToInt32(param[2]));
			}
			else if (param[0] == "ONECHANNEL_FACILITY")
			{
				string[] distributionParam = new string[param.Length - 2];
				Array.Copy(param, 2, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = CreateDistribution(distributionParam);

				return new OneChannelFacility(param[1], distribution);
			}
			else if (param[0] == "MULTYCHANNEL_FACILITY")
			{
				string[] distributionParam = new string[param.Length - 3];
				Array.Copy(param, 3, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = CreateDistribution(distributionParam);

				return new MultyChannelFacility(param[1], distribution, Convert.ToInt32(param[2]));
			}
			else if (param[0] == "INTERNAL_STATISTIC")
			{
				return new IntervalStatistic(param[1], param[2]);
			}

			else
				throw new Exception("can't create Node");
		}

		static private IDistribution CreateDistribution(string[] param)
		{
			if (param[0] == "EXPONENTIAL")
			{
				ExponentialDistribution ed = new ExponentialDistribution(
					Convert.ToInt32(param[1]),
					(float)Convert.ToDouble(param[2]));
				return ed;
			}
			if (param[0] == "UNIFORM")
			{
				UniformDistribution d = new UniformDistribution(
					Convert.ToInt32(param[1]),
					(float)Convert.ToDouble(param[2]),
					(float)Convert.ToDouble(param[3]));
				return d;
			}
			else
			{
				throw new Exception("can't create Distribution");
			}
		}
	}
}