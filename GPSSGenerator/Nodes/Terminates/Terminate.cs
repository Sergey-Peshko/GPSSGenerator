using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Terminates
{
	class Terminate : Node
	{
		private int count;
		private IntervalStatistic netLevelIntervalStatistic;

		public int Count
		{
			get
			{
				return count;
			}
		}

		public Terminate(string id, 
			int count, 
			IntervalStatistic netLevelIntervalStatistic) : base(id)
		{
			this.count = count;
			this.netLevelIntervalStatistic = netLevelIntervalStatistic;
		}

		public override List<string> buildDescription(int indexOfStream)
		{
			List<string> description = new List<string>();

			IntervalStatistic streamLevelIntervalStatistic = new IntervalStatistic(string.Format("net_{1}_stat", id, indexOfStream), string.Format("net_{1}", id, indexOfStream));

			description.Add(streamLevelIntervalStatistic.getFinish());
			description.Add(netLevelIntervalStatistic.getFinish());
			description.Add(String.Format("TERMINATE {0}", count));

			return description;
		}
	}
}
