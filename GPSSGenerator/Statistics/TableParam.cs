using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Statistics
{
	class TableParam
	{
		private int upperBoundOfLowerFrequencyInterval;
		private int intervalWidth;
		private int numberOfIntervals;

		public int UpperBoundOfLowerFrequencyInterval
		{
			get
			{
				return upperBoundOfLowerFrequencyInterval;
			}

			set
			{
				upperBoundOfLowerFrequencyInterval = value;
			}
		}

		public int IntervalWidth
		{
			get
			{
				return intervalWidth;
			}

			set
			{
				intervalWidth = value;
			}
		}

		public int NumberOfIntervals
		{
			get
			{
				return numberOfIntervals;
			}

			set
			{
				numberOfIntervals = value;
			}
		}

		public TableParam()
		{

		}
	}
}
