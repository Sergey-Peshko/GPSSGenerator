using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Statistics.IntervalStatistic;

namespace GPSSGenerator.Nodes.Statistics
{
	class FixedStateIntervalStatistic : Node 
	{
		GeneralIntervalStatistic intervalStatistic;

		private bool state;

		public FixedStateIntervalStatistic(string id, GeneralIntervalStatistic intervalStatistic, bool state) : base(id)
		{
			this.intervalStatistic = intervalStatistic;
			this.state = state;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();

			if (state)
			{
				description.Add(String.Format("QUEUE {0}", intervalStatistic.NameOfStatistic));
			}
			else
			{
				description.Add(String.Format("DEPART {0}", intervalStatistic.NameOfStatistic));
			}

			return description;
		}
	}
}
