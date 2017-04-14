using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Nodes;
using GPSSGenerator.Nodes.Distributions;
using GPSSGenerator.Nodes.Nodes.Facilities;
using GPSSGenerator.Nodes.Nodes.Facilities.CheckIners;
using GPSSGenerator.Nodes.Nodes.Facilities.CheckOuters;

namespace GPSSGenerator.Nodes
{
	class NodeFactory
	{
		static public List<INode> CreateNodes(string[][] nodes)
		{
			List<INode> rezult = new List<INode>(nodes.Length);
			for(int i = 0; i < nodes.Length; i++)
			{
				rezult.Add(CreateNode(nodes[i]));
			}
			SetDependencies(nodes, rezult);
			return rezult;
		}
		static private void SetDependencies(string[][] description, List<INode> nodes)
		{
			for(int i = 0; i < description.Length; i++)
			{
				if(description[i][0] == "Transfer")
				{
					((Transfer)nodes[i]).Node1 = nodes[FindNode(nodes, description[i][3])];
					((Transfer)nodes[i]).Node2 = nodes[FindNode(nodes, description[i][4])];
				}
			}
		}
		static private int FindNode(List<INode> nodes, string id)
		{
			for(int i = 0; i < nodes.Count; i++)
			{
				if (nodes[i].Id == id)
					return i;
			}
			return -1;
		}
		static private INode CreateNode(string[] param)
		{
			if (param[0] == "SomeNode")
			{
				return new SomeNode(param[1]);
			}
			else if (param[0] == "TRANSFER")
			{
				Transfer tmpT = new Transfer(param[1]);
				tmpT.Probability1 = Convert.ToDouble(param[2]);
				return tmpT;
			}
			else if (param[0] == "TERMINATE")
			{
				Terminate tmpT = new Terminate(param[1]);
				tmpT.Count = Convert.ToInt32(param[2]);
				return tmpT;
			}
			else if (param[0] == "GENERATOR")
			{
				Generator tmpG = new Generator(param[1]);
				string[] distributionParam = new string[param.Length - 2];
				Array.Copy(param, 2, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = DistributionFactory.CreateDistribution(distributionParam);
				tmpG.Distribution = distribution;
				return tmpG;
			}
			/*
			else if (param[0] == "START_STATISTIC")
			{

			}
			else if (param[0] == "END_STATISTIC")
			{

			}
			*/
			else if (param[0] == "FACILITY")
			{
				Facility f = new Facility(param[1]);
				string[] distributionParam = new string[param.Length - 2];
				Array.Copy(param, 2, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = DistributionFactory.CreateDistribution(distributionParam);
				f.Distribution = distribution;
				return f;
			}
			else if (param[0] == "SEIZE")
			{
				StartOneChannelRelative ocr = new StartOneChannelRelative(param[1]);
				ocr.NameOfFacility = param[2];
				return ocr;
			}
			else if (param[0] == "RELEASE")
			{
				EndOneChannelRelative ocr = new EndOneChannelRelative(param[1]);
				ocr.NameOfFacility = param[2];
				return ocr;
			}
			else
				throw new Exception("can't create Node");
		}
	}
}
