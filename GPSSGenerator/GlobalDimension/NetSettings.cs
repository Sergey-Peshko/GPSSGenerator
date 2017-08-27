using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.GlobalDimension
{
	class NetSettings
	{
		private int value;
		private bool isTime;
		private bool isTrainsactions;

		public int NumberOfItems
		{
			get
			{
				return value;
			}
		}

		public int NumberOfTransactions
		{
			set
			{
				isTrainsactions = true;
				isTime = false;
				this.value = value;
			}
		}

		public int AmountOfTime
		{
			set
			{
				isTrainsactions = false;
				isTime = true;
				this.value = value;
			}
		}

		public bool IsTime
		{
			get
			{
				return isTime;
			}
		}

		public bool IsTrainsactions
		{
			get
			{
				return isTrainsactions;
			}
		}
	}
}
