using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Generators
{
	class ClosedGenerator : Generator
	{
		int numberOfTransactions;

		public int NumberOfTransactions
		{
			get
			{
				return numberOfTransactions;
			}

			set
			{
				numberOfTransactions = value;
			}
		}

		public ClosedGenerator()
		{
			this.id = "unknown ClosedGenerator node";
		}

		public ClosedGenerator(string id)
		{
			this.id = id;
			netLevelIntervalStatistic = new IntervalStatistic(string.Format("net", id));
		}

		public override List<string> buildDescription(StreamModel streamModel)
		{
			List<string> description = new List<string>();

			IntervalStatistic streamLevelIntervalStatistic = new IntervalStatistic(string.Format("net_{1}", id, streamModel.Index));

			description.Add(String.Format("GENERATE ,,,{0}", numberOfTransactions));
			description.Add(netLevelIntervalStatistic.getStart());
			description.Add(streamLevelIntervalStatistic.getStart());

			return description;
		}
	}
}
