using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Statistics;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Facilities
{
	class OneChannelFacility : Facility
	{

		public OneChannelFacility(string id,
			IDistribution distribution) : base(id, distribution)
		{

		}

		public override List<string> buildDescription(string idOfStream)
		{
			TwoStrokeIntervalStatistic streamLevelFull = new TwoStrokeIntervalStatistic(string.Format("{0}_{1}", id, idOfStream));
			TwoStrokeIntervalStatistic streamLevelQueue = new TwoStrokeIntervalStatistic(string.Format("{0}_{1}_queue", id, idOfStream));
			List<string> description = new List<string>();

			description.AddRange(netLevelFull.buildDescription());
			description.AddRange(streamLevelFull.buildDescription());
			description.AddRange(netLevelQueue.buildDescription());
			description.AddRange(streamLevelQueue.buildDescription());
			description.Add(String.Format("SEIZE {0}", id));
			description.AddRange(streamLevelQueue.buildDescription());
			description.AddRange(netLevelQueue.buildDescription());
			description.Add(String.Format("ADVANCE ({0})", distribution.Description));
			description.Add(String.Format("RELEASE {0}", id));
			description.AddRange(streamLevelFull.buildDescription());
			description.AddRange(netLevelFull.buildDescription());

			return description;
		}
	}
}
