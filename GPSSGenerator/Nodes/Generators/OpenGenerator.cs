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

		public OpenGenerator()
		{
			this.id = "unknown GeneratorNode node";
		}

		public OpenGenerator(string id)
		{
			this.id = id;
		}

		public override List<string> buildDescription(StreamModel streamModel)
		{
			List<string> description = new List<string>();

			IntervalStatistic streamLevelIntervalStatistic = new IntervalStatistic(string.Format("net_{1}", id, streamModel.Index));

			description.Add(String.Format("GENERATE ({0})", distribution.Description));
			description.Add(netLevelIntervalStatistic.getStart());
			description.Add(streamLevelIntervalStatistic.getStart());

			return description;
		}
	}
}
