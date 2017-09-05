using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Nodes;

namespace GPSSGenerator.Statistics
{
	class IntervalStatistic : Statistic, IDeclarative
	{
		private bool state = true;
		private TableParam tableParam;
		public IntervalStatistic(string nameOfStatistic) : base(nameOfStatistic)
		{
		}

		public TableParam TableParam
		{
			get
			{
				return tableParam;
			}

			set
			{
				tableParam = value;
			}
		}

		public string getStart()
		{
			return String.Format("QUEUE {0}", nameOfStatistic);
		}

		public string getFinish()
		{
			return String.Format("DEPART {0}", nameOfStatistic);
		}

		public List<string> buildDeclaration()
		{
			List<string> description = new List<string>();

			if (TableParam != null)
			{
				description.Add(String.Format("qtable_{0} QTABLE {0},{1},{2},{3}",
					NameOfStatistic,
					TableParam.UpperBoundOfLowerFrequencyInterval,
					TableParam.IntervalWidth,
					TableParam.NumberOfIntervals));
			}

			return description;
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
