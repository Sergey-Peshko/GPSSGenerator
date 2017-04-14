using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Distributions
{
	class ExponentialDistribution : IDistribution
	{
		private float mathematicalExpectation;

		public override string Description
		{
			get
			{
				description = String.Format("EXPONENTIAL ({0},0,{1})", numberOfGenerator, mathematicalExpectation);
				return description;
			}
		}

		public float MathematicalExpectation
		{
			get
			{
				return mathematicalExpectation;
			}

			set
			{
				mathematicalExpectation = value;
			}
		}

		public ExponentialDistribution()
		{

		}
	}
}
