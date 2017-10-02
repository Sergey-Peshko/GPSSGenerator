using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Statistics;

namespace GPSSGenerator.Nodes.Facilities
{
	abstract class Facility : Node
	{
		protected Distribution distribution;

		protected IntervalStatistic netLevelFull;
		protected IntervalStatistic netLevelQueue;

		public Facility(string id, Distribution distribution) : base(id)
		{
			netLevelFull = new IntervalStatistic(id);
			netLevelQueue = new IntervalStatistic(id + "_queue");
			this.distribution = distribution;
		}

		public Distribution Distribution
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
