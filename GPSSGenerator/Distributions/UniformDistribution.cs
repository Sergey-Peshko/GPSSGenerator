using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Distributions
{
	class UniformDistribution : Distribution
	{
		private float a; // нижняя граница
		private float b; // верхняя граница

		public override string Description
		{
			get
			{
				description = String.Format("UNIFORM ({0},{1},{2})", numberOfGenerator, a, b);
				return description;
			}
		}

		public UniformDistribution(int numberOfGenerator, float a, float b) : base(numberOfGenerator)
		{
			this.a = a;
			this.b = b;
		}

		public float A
		{
			get
			{
				return a;
			}
		}

		public float B
		{
			get
			{
				return b;
			}
		}

	}
}
