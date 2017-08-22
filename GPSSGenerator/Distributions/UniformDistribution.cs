using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Distributions
{
	class UniformDistribution : IDistribution
	{
		private float a;
		private float b;

		public override string Description
		{
			get
			{
				description = String.Format("UNIFORM ({0},{1},{2})", numberOfGenerator, a, b);
				return description;
			}
		}

		public UniformDistribution()
		{

		}

		public float A
		{
			get
			{
				return a;
			}

			set
			{
				a = value;
			}
		}

		public float B
		{
			get
			{
				return b;
			}

			set
			{
				b = value;
			}
		}

	}
}
