using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Statistics
{
	abstract class Statistic
	{
		protected string nameOfStatistic;

		public string NameOfStatistic
		{
			get
			{
				return nameOfStatistic;
			}
		}

		public Statistic(string nameOfStatistic)
		{
			this.nameOfStatistic = nameOfStatistic;
		}
	}
}
