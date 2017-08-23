﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Statistics;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Terminates
{
	class Terminate : Node
	{
		private int count;
		private IntervalStatistic netLevelIntervalStatistic;

		public int Count
		{
			get
			{
				return count;
			}
		}

		public Terminate()
		{
			this.id = "unknown Terminate node";
		}

		public Terminate(string id)
		{
			this.id = id;
		}

		public override List<string> buildDescription(StreamModel streamModel)
		{
			List<string> description = new List<string>();

			IntervalStatistic streamLevelIntervalStatistic = new IntervalStatistic(string.Format("net_{1}", id, streamModel.Index));

			description.Add(streamLevelIntervalStatistic.getFinish());
			description.Add(netLevelIntervalStatistic.getFinish());
			description.Add(String.Format("TERMINATE {0}", count));

			return description;
		}
	}
}
