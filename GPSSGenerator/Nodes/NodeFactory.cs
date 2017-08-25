using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Transfers;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Facilities;
using GPSSGenerator.Nodes.Generators;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.Nodes.Terminates;


namespace GPSSGenerator.Nodes
{
	class NodeFactory
	{
		static private IntervalStatistic netLevel = new IntervalStatistic("net_stat","net");

		static public List<Entity> CreateNodes(string[][] nodes)
		{
			List<Entity> rezult = new List<Entity>(nodes.Length);
			for (int i = 0; i < nodes.Length; i++)
			{
				rezult.Add(CreateNode(nodes[i]));
			}
			return rezult;
		}

		static private Entity CreateNode(string[] param)
		{
			if (param[0] == "TERMINATE")
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
				IDistribution distribution = DistributionFactory.CreateDistribution(distributionParam);
				return new OpenGenerator(param[1], netLevel, distribution); ;
			}
			else if (param[0] == "ZGENERATOR")
			{
				return new ClosedGenerator(param[1], netLevel, Convert.ToInt32(param[2])); 
			}
			else if (param[0] == "FACILITY_ONECHANNEL_RELATIVE")
			{
				string[] distributionParam = new string[param.Length - 2];
				Array.Copy(param, 2, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = DistributionFactory.CreateDistribution(distributionParam);
				
				return new OneChannelRelativeFacility(param[1], distribution);
			}
			else if (param[0] == "FACILITY_MULTYCHANNEL")
			{
				string[] distributionParam = new string[param.Length - 3];
				Array.Copy(param, 3, distributionParam, 0, distributionParam.Length);
				IDistribution distribution = DistributionFactory.CreateDistribution(distributionParam);
				
				return new MultyChannelFacility(param[1], distribution, Convert.ToInt32(param[2])); 
			}
			else if (param[0] == "INTERNAL_STATISTIC")
			{
				return new IntervalStatistic(param[1], param[2]);
			}

			else
				throw new Exception("can't create Node");
		}
	}
}
