using System;
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

		public OpenGenerator(string id, TwoStrokeIntervalStatistic netLevelIntervalStatistic, IDistribution distribution) : base(id, netLevelIntervalStatistic)
		{
			this.distribution = distribution;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();

			description.Add(String.Format("GENERATE ({0})", distribution.Description));
			description.Add(netLevelIntervalStatistic.getStart());

			return description;
		}
	}
}
