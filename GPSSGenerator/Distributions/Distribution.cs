using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Distributions
{
	abstract class Distribution
	{
		protected string description;
		protected int numberOfGenerator;

		abstract public string Description { get; }

		public int NumberOfGenerator
		{
			get
			{
				return numberOfGenerator;
			}
		}

		public Distribution(int numberOfGenerator)
		{
			this.numberOfGenerator = numberOfGenerator;
		}
	}
}
