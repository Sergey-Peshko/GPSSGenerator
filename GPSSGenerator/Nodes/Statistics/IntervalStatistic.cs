using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Statistics
{
	class IntervalStatistic : Node
	{
		private string nameOfStatistic;
		private bool state = true;

		public string NameOfStatistic
		{
			get
			{
				return nameOfStatistic;
			}

			set
			{
				nameOfStatistic = value;
			}
		}

		public IntervalStatistic()
		{
			this.id = "unknown StartStatistic node";
		}

		public IntervalStatistic(string id)
		{
			this.id = id;
		}

		public string getStart()
		{
			return String.Format("QUEUE {0}", nameOfStatistic);
		}

		public string getFinish()
		{
			return String.Format("DEPART {0}", nameOfStatistic);
		}

		public override List<string> buildDescription(StreamModel streamModel)
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
