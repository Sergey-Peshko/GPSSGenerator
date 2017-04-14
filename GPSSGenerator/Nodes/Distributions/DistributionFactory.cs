using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Distributions
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
			else
			{
				throw new Exception("can't create Distribution");
			}
		}
	}
}
