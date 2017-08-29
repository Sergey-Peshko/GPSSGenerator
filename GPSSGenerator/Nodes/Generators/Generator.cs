using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Statistics;

namespace GPSSGenerator.Nodes.Generators
{
	abstract class Generator : Node
	{
		protected TwoStrokeIntervalStatistic netLevelIntervalStatistic;

		public Generator(string id, TwoStrokeIntervalStatistic netLevelIntervalStatistic) : base(id)
		{
			this.netLevelIntervalStatistic = netLevelIntervalStatistic;
		}
	}
}
