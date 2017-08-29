using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Statistics
{
	class StartIntervalStatistic : Node
	{
		GeneralIntervalStatistic intervalStatistic;

		public StartIntervalStatistic(string id, GeneralIntervalStatistic intervalStatistic) : base(id)
		{
			this.intervalStatistic = intervalStatistic;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();

			description.Add(String.Format("QUEUE {0}", intervalStatistic.NameOfStatistic));

			return description;
		}
	}
}
