using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.GlobalDemension
{
	class NetSettingscs
	{
		static private string typeOfNet;
		static private int numberOfStreams;
		static private int numberOfTransactions;

		public static int NumberOfTransactions
		{
			get
			{
				return numberOfTransactions;
			}

			set
			{
				numberOfTransactions = value;
			}
		}

		public static int NumberOfStreams
		{
			get
			{
				return numberOfStreams;
			}

			set
			{
				numberOfStreams = value;
			}
		}

		public static string TypeOfNet
		{
			get
			{
				return typeOfNet;
			}

			set
			{
				typeOfNet = value;
			}
		}
	}
}
