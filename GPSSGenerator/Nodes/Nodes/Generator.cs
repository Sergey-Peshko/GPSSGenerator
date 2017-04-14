using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Distributions;

namespace GPSSGenerator.Nodes.Nodes
{
	class Generator : INode
	{
		IDistribution distribution;
		public override string Description
		{
			get
			{
				description = String.Format("GENERATE ({0})", distribution.Description);
				return description;
			}
		}

		internal IDistribution Distribution
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

		public Generator()
		{
			this.id = "unknown GeneratorNode node";
		}

		public Generator(string name)
		{
			this.id = name;
			label = string.Format("Label_{0}", name);
		}
	}
}
