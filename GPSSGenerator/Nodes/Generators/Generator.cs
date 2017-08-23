using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Statistics;

namespace GPSSGenerator.Nodes.Generators
{
	abstract class Generator : Node
	{
		protected IntervalStatistic netLevelIntervalStatistic;

		public IntervalStatistic NetLevelStatistic
		{
			get
			{
				return netLevelIntervalStatistic;
			}
		}
	}
}
