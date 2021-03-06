﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Statistics;

namespace GPSSGenerator.Nodes.Generators
{
	abstract class Generator : Node
	{
		protected IntervalStatistic netLevelIntervalStatistic;

		public Generator(string id, IntervalStatistic netLevelIntervalStatistic) : base(id)
		{
			this.netLevelIntervalStatistic = netLevelIntervalStatistic;
		}
	}
}
