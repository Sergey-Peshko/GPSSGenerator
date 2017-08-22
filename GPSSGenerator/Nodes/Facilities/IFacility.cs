using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;

namespace GPSSGenerator.Nodes.Facilities
{
	abstract class IFacility : StreamNodeDecorator
	{
		protected IDistribution distribution;
		protected List<StartStatistic> sStat;
		protected List<EndStatistic> eStat;

		public IDistribution Distribution
		{
			get
			{
				return distribution;
			}

			set
			{
				distribution = value;
			}
		}

		public List<StartStatistic> ListStartStatistic
		{
			get
			{
				return sStat;
			}

			set
			{
				sStat = value;
			}
		}

		public List<EndStatistic> ListEndStatistic
		{
			get
			{
				return eStat;
			}

			set
			{
				eStat = value;
			}
		}
	}
}
