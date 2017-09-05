using GPSSGenerator.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Statistics
{
	class OnePointStatisticNode : Node
	{
		OnePointStatistic onePointStatistic;

		public OnePointStatisticNode(string id, OnePointStatistic onePointStatistic) : base(id)
		{
			this.onePointStatistic = onePointStatistic;
		}
		public override List<string> buildDescription(string idOfStream)
		{
			return onePointStatistic.buildDescription();
		}
	}
}
