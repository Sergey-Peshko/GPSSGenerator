﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.StreamDimension;

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

		public override List<string> buildDescription(int indexOfStream)
		{
			List<string> description = new List<string>();

			IntervalStatistic streamLevelIntervalStatistic = new IntervalStatistic(string.Format("net_{1}_stat", id, indexOfStream), string.Format("net_{1}", id, indexOfStream));

			description.Add(String.Format("GENERATE ({0})", distribution.Description));
			description.Add(netLevelIntervalStatistic.getStart());
			description.Add(streamLevelIntervalStatistic.getStart());

			return description;
		}
	}
}
