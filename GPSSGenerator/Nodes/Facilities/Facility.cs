using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;

namespace GPSSGenerator.Nodes.Facilities
{
	abstract class Facility : Node
	{
		protected IDistribution distribution;

		protected IntervalStatistic netLevelFull;
		protected IntervalStatistic netLevelQueue;

		public IDistribution Distribution
		{
			get
			{
				return distribution;
			}
		}

		public IntervalStatistic NetLevelFull
		{
			get
			{
				return netLevelFull;
			}
		}

		public IntervalStatistic NetLevelQueue
		{
			get
			{
				return netLevelQueue;
			}
		}
	}
}
