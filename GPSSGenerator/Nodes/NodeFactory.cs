using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Nodes;
using GPSSGenerator.Nodes.Distributions;
using GPSSGenerator.Nodes.Nodes.Facilities;

namespace GPSSGenerator.Nodes
{
	class NodeFactory
	{
		static private StartStatistic startFull;
		static private EndStatistic endFull;

		static public List<INode> CreateNodes(string[][] nodes)
		{
			startFull = new StartStatistic();
			startFull.NameOfStatistic = "net";
			endFull = new EndStatistic();
			endFull.NameOfStatistic = "net";


			List<INode> rezult = new List<INode>(nodes.Length);
			for(int i = 0; i < nodes.Length; i++)
			{
				rezult.Add(CreateNode(nodes[i]));
			}
			//SetDependencies(nodes, rezult);
			return rezult;
		}
		/*
		static private void SetDependencies(string[][] description, List<INode> nodes)
		{
			for(int i = 0; i < description.Length; i++)
			{
				if(description[i][0] == "TRANSFER")
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
		*/
		static private INode CreateNode(string[] param)
		{
			if (param[0] == "SomeNode")
			{
				return new SomeNode(param[1]);
			}
			/*
			else if (param[0] == "TRANSFER")
			{
				Transfer tmpT = new Transfer(param[1]);
				tmpT.Probability1 = Convert.ToDouble(param[2]);
				return tmpT;
			}
			*/
			else if (param[0] == "TERMINATE")
			{
				Terminate tmpT = new Terminate(param[1]);
				tmpT.Count = Convert.ToInt32(param[2]);
				tmpT.EndFullStatistic = endFull;
				return tmpT;
			}
			else if (param[0] == "GENERATOR")
			{
				Generator tmpG = new Generator(param[1]);
				string[] distributionParam = new string[param.Length - 2];
				Array.Copy(param, 2, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = DistributionFactory.CreateDistribution(distributionParam);
				tmpG.Distribution = distribution;
				tmpG.StartFullStatistic = startFull;
				return tmpG;
			}
			else if (param[0] == "FACILITY_ONE_CHANNEL_RELATIVE")
			{
				OneChannelRelative ocr = new OneChannelRelative(param[1]);
				string[] distributionParam = new string[param.Length - 2];
				Array.Copy(param, 2, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = DistributionFactory.CreateDistribution(distributionParam);
				ocr.Distribution = distribution;
				List<StartStatistic> lsst = new List<StartStatistic>();
				StartStatistic smu = new StartStatistic();
				smu.NameOfStatistic = String.Format("{0}_STREAM#", param[1]);
				StartStatistic sw = new StartStatistic();
				sw.NameOfStatistic = String.Format("{0}_STREAM#_queue", param[1]);
				lsst.Add(smu);
				lsst.Add(sw);
				List<EndStatistic> lest = new List<EndStatistic>();
				EndStatistic emu = new EndStatistic();
				emu.NameOfStatistic = String.Format("{0}_STREAM#", param[1]);
				EndStatistic ew = new EndStatistic();
				ew.NameOfStatistic = String.Format("{0}_STREAM#_queue", param[1]);
				lest.Add(emu);
				lest.Add(ew);
				ocr.ListStartStatistic = lsst;
				ocr.ListEndStatistic = lest;
				return ocr;
			}
			
			else if (param[0] == "START_STATISTIC")
			{
				StartStatistic s = new StartStatistic(param[1]);
				s.NameOfStatistic = param[2];
				return s;
			}
			else if (param[0] == "END_STATISTIC")
			{
				EndStatistic e = new EndStatistic(param[1]);
				e.NameOfStatistic = param[2];
				return e;
			}
			
			else
				throw new Exception("can't create Node");
		}
	}
}
