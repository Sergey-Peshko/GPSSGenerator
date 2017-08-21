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
		public static string[] typesOfNode = {
			"CLOSED_GENERATOR",
			"GENERATOR",
			"FACILITY_ONECHANNEL_RELATIVE",
			"FACILITY_MULTYCHANNEL",
			"TERMINATE",
			"START_STATISTIC",
			"END_STATISTIC"
		};
		public static string[] typesOfDistribution = {
			"EXPONENTIAL",
			"UNIFORM",
		};
		public static string[] typesOfNet =
		{
			"Closed",
			"Open",
			"Mixied"
		};
	}
}
