using GPSSGenerator.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Statistics.IntervalStatistic
{
	class GeneralIntervalStatistic : Statistic , IDeclarative
	{
		private TableParam tableParam;
		public GeneralIntervalStatistic(string nameOfStatistic) : base(nameOfStatistic)
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
	}
}
