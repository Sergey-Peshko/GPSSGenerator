using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Distributions
{
	class DistributionFactory
	{
		public static IDistribution CreateDistribution(string[] param)
		{
			if (param[0] == "EXPONENTIAL")
			{
				ExponentialDistribution ed = new ExponentialDistribution();
				ed.NumberOfGenerator = Convert.ToInt32(param[1]);
				ed.MathematicalExpectation = (float)Convert.ToDouble(param[2]);
				return ed;
			}
			if (param[0] == "UNIFORM")
			{
				UniformDistribution d = new UniformDistribution();
				d.NumberOfGenerator = Convert.ToInt32(param[1]);
				d.A = (float)Convert.ToDouble(param[2]);
				d.B = (float)Convert.ToDouble(param[3]);
				return d;
			}
			else
			{
				throw new Exception("can't create Distribution");
			}
		}
	}
}
