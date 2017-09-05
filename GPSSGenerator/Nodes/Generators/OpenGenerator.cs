using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Statistics;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Statistics;

namespace GPSSGenerator.Nodes.Generators
{
	class OpenGenerator : Generator
	{
		IDistribution distribution;

		public IDistribution Distribution
		{
			get
			{
				return distribution;
			}
		}

		public OpenGenerator(string id, IntervalStatistic netLevelIntervalStatistic, IDistribution distribution) : base(id, netLevelIntervalStatistic)
		{
			this.distribution = distribution;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();

			IntervalStatistic streamLevelIntervalStatistic = new IntervalStatistic(string.Format("net_{0}", idOfStream));

			description.Add(String.Format("GENERATE ({0})", distribution.Description));
			description.Add(netLevelIntervalStatistic.getStart());
			description.Add(streamLevelIntervalStatistic.getStart());

			return description;
		}
	}
}
