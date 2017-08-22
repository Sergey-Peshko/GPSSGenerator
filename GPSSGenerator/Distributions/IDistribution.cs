using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Distributions
{
	abstract class IDistribution
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

			set
			{
				numberOfGenerator = value;
			}
		}
	}
}
