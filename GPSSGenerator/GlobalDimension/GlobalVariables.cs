using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.GlobalDimension
{
	public class GlobalVariables
	{
		internal static int counterOfTransfers = 0;

		private static int uniqCounter = 0;

		public static string getUniqName()
		{
			return string.Format("var{0}", uniqCounter++);
		}

		public static string ZGENERATOR = "ZGENERATOR";
		public static string GENERATOR = "GENERATOR";
		public static string RECEIVER = "RECEIVER";
		public static string ONECHANNEL_FACILITY = "ONECHANNEL_FACILITY";
		public static string MULTYCHANNEL_FACILITY = "MULTYCHANNEL_FACILITY";

		public static string[] typesOfNode = {
			ZGENERATOR,
			GENERATOR,
			RECEIVER,
			ONECHANNEL_FACILITY,
			MULTYCHANNEL_FACILITY
		};

		public static string EXPONENTIAL = "EXPONENTIAL";
		public static string UNIFORM = "UNIFORM";

		public static string[] typesOfDistribution = {
			EXPONENTIAL,
			UNIFORM,
		};

		public static string INTERVAL_STATISTIC = "INTERVAL_STATISTIC";
		public static string ONEPOINT_STATISTIC = "ONEPOINT_STATISTIC";
	}
}
