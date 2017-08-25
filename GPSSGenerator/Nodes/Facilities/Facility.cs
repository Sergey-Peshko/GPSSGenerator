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

		public Facility(string id, IDistribution distribution) : base(id)
		{
			netLevelFull = new IntervalStatistic(id + "_stat", id);
			netLevelQueue = new IntervalStatistic(id + "_queue_stat", id + "_queue");
			this.distribution = distribution;
		}

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
