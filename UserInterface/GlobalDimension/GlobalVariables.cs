using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.GlobalDimension
{
	class GlobalVariables
	{
		public static int counterOfTransfers = 0;
		public static string data = "C:\\Users\\peshk\\Documents\\Visual Studio 2015\\Projects\\GPSSGenerator\\UserInterface\\data\\";
		public static string rez = "C:\\Users\\peshk\\Documents\\Visual Studio 2015\\Projects\\GPSSGenerator\\UserInterface\\rez\\";
		public static List<string> typesOfNode;
		public static List<string> typesOfDistribution;
		public static List<string> typesOfNet;

		static GlobalVariables()
		{
			typesOfNode = new List<string>();
			typesOfNode.Add("GENERATOR");
			typesOfNode.Add("FACILITY_ONECHANNEL_RELATIVE");
			typesOfNode.Add("FACILITY_MULTYCHANNEL");
			typesOfNode.Add("TERMINATE");
			typesOfNode.Add("START_STATISTIC");
			typesOfNode.Add("END_STATISTIC");
			typesOfDistribution = new List<string>();
			typesOfDistribution.Add("EXPONENTIAL");
			typesOfDistribution.Add("UNIFORM");
			typesOfNet = new List<string>();
			typesOfNet.Add("Разомкнутая");
			typesOfNet.Add("Замкнутая");
		}
	}
}
