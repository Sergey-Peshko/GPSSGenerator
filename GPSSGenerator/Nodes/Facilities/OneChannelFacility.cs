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
	class OneChannelFacility : Facility
	{

		public OneChannelFacility(string id,
			IDistribution distribution) : base(id, distribution)
		{

		}

		public override List<string> buildDescription(string idOfStream)
		{
			IntervalStatistic streamLevelFull = new IntervalStatistic(string.Format("{0}_{1}_stat", id, idOfStream),
				string.Format("{0}_{1}", id, idOfStream));
			IntervalStatistic streamLevelQueue = new IntervalStatistic(string.Format("{0}_{1}_queue_stat", id, idOfStream),
				string.Format("{0}_{1}_queue", id, idOfStream));
			List<string> description = new List<string>();

			description.AddRange(netLevelFull.buildDescription(idOfStream));
			description.AddRange(streamLevelFull.buildDescription(idOfStream));
			description.AddRange(netLevelQueue.buildDescription(idOfStream));
			description.AddRange(streamLevelQueue.buildDescription(idOfStream));
			description.Add(String.Format("SEIZE {0}", id));
			description.AddRange(streamLevelQueue.buildDescription(idOfStream));
			description.AddRange(netLevelQueue.buildDescription(idOfStream));
			description.Add(String.Format("ADVANCE ({0})", distribution.Description));
			description.Add(String.Format("RELEASE {0}", id));
			description.AddRange(streamLevelFull.buildDescription(idOfStream));
			description.AddRange(netLevelFull.buildDescription(idOfStream));

			return description;
		}
	}
}
