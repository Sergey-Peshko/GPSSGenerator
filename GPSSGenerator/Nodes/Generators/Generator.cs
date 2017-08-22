using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;

namespace GPSSGenerator.Nodes.Generators
{
	class Generator : StreamNodeDecorator
	{
		IDistribution distribution;
		StartStatistic startFullStatistic;
		public override List<string> Description
		{
			get
			{
				if (description.Count == 0)
				{
					description.Add(String.Format("GENERATE ({0})", distribution.Description));
					description.AddRange(startFullStatistic.Description);
				}
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

		internal StartStatistic StartFullStatistic
		{
			get
			{
				return startFullStatistic;
			}

			set
			{
				startFullStatistic = value;
			}
		}

		public Generator()
		{
			this.id = "unknown GeneratorNode node";
		}

		public Generator(string id)
		{
			canItHaveLabel = false;
			this.id = id;
		}

		public override StreamNodeDecorator GetNewInstanseOfIStreamNodeWithINodeData()
		{
			Generator newNode = new Generator();
			INode.Copy(this, newNode);
			return newNode;
		}
	}
}
