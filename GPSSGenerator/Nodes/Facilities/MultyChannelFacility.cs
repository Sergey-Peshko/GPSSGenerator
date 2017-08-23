using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.Nodes;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Facilities
{
	class MultyChannelFacility : Facility, IDeclarative
	{
		private int numberOfChannel;

		public int NumberOfChannel
		{
			get
			{
				return numberOfChannel;
			}
		}

		public MultyChannelFacility()
		{
			this.id = "unknown OneChannelRelative node";
		}

		public MultyChannelFacility(string id, 
			IDistribution distribution,
			int numberOfChannel)
		{
			this.id = id;
			this.distribution = distribution;

			netLevelFull = new IntervalStatistic(string.Format("{0}", id));
			netLevelQueue = new IntervalStatistic(string.Format("{0}_queue", id));

			this.numberOfChannel = numberOfChannel;
		}

		public List<string> buildDeclaration()
		{
			List<string> declaration = new List<string>();
			declaration.Add(String.Format("{0} STORAGE {1}", id, numberOfChannel));
			return declaration;
		}

		public override List<string> buildDescription(StreamModel streamModel)
		{

			IntervalStatistic streamLevelFull = new IntervalStatistic(string.Format("{0}_{1}", id, streamModel.Index));
			IntervalStatistic streamLevelQueue = new IntervalStatistic(string.Format("{0}_{1}_queue", id, streamModel.Index));
			
			List<string> description = new List<string>();

			description.AddRange(netLevelFull.buildDescription(streamModel));
			description.AddRange(streamLevelFull.buildDescription(streamModel));
			description.AddRange(netLevelQueue.buildDescription(streamModel));
			description.AddRange(streamLevelQueue.buildDescription(streamModel));
			description.Add(String.Format("ENTER {0}", id));
			description.AddRange(streamLevelQueue.buildDescription(streamModel));
			description.AddRange(netLevelQueue.buildDescription(streamModel));
			description.Add(String.Format("ADVANCE ({0})", distribution.Description));
			description.Add(String.Format("LEAVE {0}", id));
			description.AddRange(streamLevelFull.buildDescription(streamModel));
			description.AddRange(netLevelFull.buildDescription(streamModel));

			return description;
		}
	}
}
