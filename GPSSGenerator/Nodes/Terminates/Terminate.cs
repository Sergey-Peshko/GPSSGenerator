using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Statistics.IntervalStatistic;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Terminates
{
	class Terminate : Node
	{
		private int count;
		private TwoStrokeIntervalStatistic netLevelIntervalStatistic;

		public int Count
		{
			get
			{
				return count;
			}
		}

		public Terminate(string id, 
			int count,
			TwoStrokeIntervalStatistic netLevelIntervalStatistic) : base(id)
		{
			this.count = count;
			this.netLevelIntervalStatistic = netLevelIntervalStatistic;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();

			TwoStrokeIntervalStatistic streamLevelIntervalStatistic = new TwoStrokeIntervalStatistic(string.Format("net_{0}", idOfStream));

			description.Add(streamLevelIntervalStatistic.getFinish());
			description.Add(netLevelIntervalStatistic.getFinish());
			description.Add(String.Format("TERMINATE {0}", count));

			return description;
		}
	}
}
