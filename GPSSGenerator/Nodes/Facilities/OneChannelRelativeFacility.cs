using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Facilities
{
	class OneChannelRelativeFacility : Facility
	{

		public OneChannelRelativeFacility(string id,
			IDistribution distribution) : base(id, distribution)
		{

		}

		public override List<string> buildDescription(int indexOfStream)
		{
			IntervalStatistic streamLevelFull = new IntervalStatistic(string.Format("{0}_{1}_stat", id, indexOfStream),
				string.Format("{0}_{1}", id, indexOfStream));
			IntervalStatistic streamLevelQueue = new IntervalStatistic(string.Format("{0}_{1}_queue_stat", id, indexOfStream),
				string.Format("{0}_{1}_queue", id, indexOfStream));
			List<string> description = new List<string>();

			description.AddRange(netLevelFull.buildDescription(indexOfStream));
			description.AddRange(streamLevelFull.buildDescription(indexOfStream));
			description.AddRange(netLevelQueue.buildDescription(indexOfStream));
			description.AddRange(streamLevelQueue.buildDescription(indexOfStream));
			description.Add(String.Format("SEIZE {0}", id));
			description.AddRange(streamLevelQueue.buildDescription(indexOfStream));
			description.AddRange(netLevelQueue.buildDescription(indexOfStream));
			description.Add(String.Format("ADVANCE ({0})", distribution.Description));
			description.Add(String.Format("RELEASE {0}", id));
			description.AddRange(streamLevelFull.buildDescription(indexOfStream));
			description.AddRange(netLevelFull.buildDescription(indexOfStream));

			return description;
		}
	}
}
