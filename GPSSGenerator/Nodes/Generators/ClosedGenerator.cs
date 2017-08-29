using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Statistics;

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

		public ClosedGenerator(string id, TwoStrokeIntervalStatistic netLevelIntervalStatistic, int numberOfTransactions) : base(id, netLevelIntervalStatistic)
		{
			this.numberOfTransactions = numberOfTransactions;
		}

		public override List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();

			description.Add(String.Format("GENERATE ,,,{0}", numberOfTransactions));
			description.Add(netLevelIntervalStatistic.getStart());

			return description;
		}
	}
}
