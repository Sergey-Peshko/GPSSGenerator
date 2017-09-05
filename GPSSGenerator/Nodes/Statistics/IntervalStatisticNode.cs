using GPSSGenerator.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Statistics
{
	class IntervalStatisticNode : Node
	{
		IntervalStatistic intervalStatistic;

		public IntervalStatisticNode(string id, IntervalStatistic intervalStatistic) : base(id)
		{
			this.intervalStatistic = intervalStatistic;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			return intervalStatistic.buildDescription();
		}
	}
}
