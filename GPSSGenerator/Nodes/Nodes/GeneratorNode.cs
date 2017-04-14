using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Distributions;

namespace GPSSGenerator.Nodes.Nodes
{
	class GeneratorNode : INode
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

		public GeneratorNode()
		{
			this.name = "unknown GeneratorNode node";
		}

		public GeneratorNode(string name)
		{
			this.name = name;
			label = string.Format("Label_{0}", name);
		}
	}
}
