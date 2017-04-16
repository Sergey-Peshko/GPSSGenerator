using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.GlobalDimension
{
	class NetSettings
	{
		private string typeOfNet;
		private int numberOfStreams;
		private int numberOfTransactions;

		public int NumberOfTransactions
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

		public string TypeOfNet
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
