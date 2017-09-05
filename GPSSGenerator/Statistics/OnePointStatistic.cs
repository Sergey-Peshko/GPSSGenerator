using GPSSGenerator.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.GlobalDimension;

namespace GPSSGenerator.Statistics
{
	class OnePointStatistic : Statistic, IDeclarative
	{
		private TableParam tableParam;

		private string var1 = GlobalVariables.getUniqName();
		private string var2 = GlobalVariables.getUniqName();

		public OnePointStatistic(string nameOfStatistic) : base(nameOfStatistic)
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
				description.Add(String.Format("INITIAL X${0},{1}",var1,0));
				description.Add(String.Format("{0} VARIABLE AC1-{1}",var2, var1));
				description.Add(String.Format("{0} TABLE {0},{1},{2},{3}",
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

			
			description.Add(String.Format("TABULATE {0}", nameOfStatistic));
			description.Add(String.Format("SAVEVALUE {0},AC1", var1));


			return description;
		}
	}
}
