using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Statistics;
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

		public MultyChannelFacility(string id, 
			IDistribution distribution,
			int numberOfChannel) : base(id, distribution)
		{
			this.numberOfChannel = numberOfChannel;
		}

		public List<string> buildDeclaration()
		{
			List<string> declaration = new List<string>();
			declaration.Add(String.Format("{0} STORAGE {1}", id, numberOfChannel));
			return declaration;
		}

		public override List<string> buildDescription(string idOfStream)
		{

			IntervalStatistic streamLevelFull = new IntervalStatistic(string.Format("{0}_{1}", id, idOfStream));
			IntervalStatistic streamLevelQueue = new IntervalStatistic(string.Format("{0}_{1}_queue", id, idOfStream));
			
			List<string> description = new List<string>();

			description.AddRange(netLevelFull.buildDescription());
			description.AddRange(streamLevelFull.buildDescription());
			description.AddRange(netLevelQueue.buildDescription());
			description.AddRange(streamLevelQueue.buildDescription());
			description.Add(String.Format("ENTER {0}", id));
			description.AddRange(streamLevelQueue.buildDescription());
			description.AddRange(netLevelQueue.buildDescription());
			description.Add(String.Format("ADVANCE ({0})", distribution.Description));
			description.Add(String.Format("LEAVE {0}", id));
			description.AddRange(streamLevelFull.buildDescription());
			description.AddRange(netLevelFull.buildDescription());

			return description;
		}
	}
}
