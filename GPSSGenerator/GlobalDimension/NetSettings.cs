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
		private int amountOfTime;
		private bool isTime;
		private bool isTrainsactions;

		public int NumberOfTransactions
		{
			get
			{
				return numberOfTransactions;
			}

			set
			{
				amountOfTime = default(int);
				numberOfTransactions = value;
			}
		}

		public int AmountOfTime
		{
			get
			{
				return amountOfTime;
			}

			set
			{
				numberOfTransactions = default(int);
				amountOfTime = value;
			}
		}

		public bool IsTime
		{
			get
			{
				return isTime;
			}

			set
			{
				isTrainsactions = !value;
				isTime = value;
			}
		}

		public bool IsTrainsactions
		{
			get
			{
				return isTrainsactions;
			}

			set
			{
				isTime = !value;
				isTrainsactions = value;
			}
		}
	}
}
