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

		protected TwoStrokeIntervalStatistic netLevelFull;
		protected TwoStrokeIntervalStatistic netLevelQueue;

		public Facility(string id, IDistribution distribution) : base(id)
		{
			netLevelFull = new TwoStrokeIntervalStatistic(id);
			netLevelQueue = new TwoStrokeIntervalStatistic(id + "_queue");
			this.distribution = distribution;
		}

		public IDistribution Distribution
		{
			get
			{
				return distribution;
			}
		}

		public TwoStrokeIntervalStatistic NetLevelFull
		{
			get
			{
				return netLevelFull;
			}
		}

		public TwoStrokeIntervalStatistic NetLevelQueue
		{
			get
			{
				return netLevelQueue;
			}
		}
	}
}
