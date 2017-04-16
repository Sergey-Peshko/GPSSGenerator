using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.GlobalDimension
{
	class NetSettings
	{
		private int numberOfTransactions;
		private int numberOfTime;
		private bool isTime;

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
	}
}
