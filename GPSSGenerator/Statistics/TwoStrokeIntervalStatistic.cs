using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Statistics
{
	class TwoStrokeIntervalStatistic : GeneralIntervalStatistic
	{
		private bool state = true;

		public TwoStrokeIntervalStatistic(string nameOfStatistic) : base(nameOfStatistic)
		{

		}

		public string getStart()
		{
			return String.Format("QUEUE {0}", nameOfStatistic);
		}

		public string getFinish()
		{
			return String.Format("DEPART {0}", nameOfStatistic);
		}

		public List<string> buildDescription()
		{
			List<string> description = new List<string>();

			if (state)
			{
				description.Add(String.Format("QUEUE {0}", nameOfStatistic));
			}
			else
			{
				description.Add(String.Format("DEPART {0}", nameOfStatistic));
			}

			state = !state;

			return description;
		}
	}
}
