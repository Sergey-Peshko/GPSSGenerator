using GPSSGenerator.Distributions;
using GPSSGenerator.Nodes.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Generators
{
	class ClosedGenerator : StreamNodeDecorator
	{
		int numberOfTransactions;
		StartStatistic startFullStatistic;
		public override List<string> Description
		{
			get
			{
				if (description.Count == 0)
				{
					description.Add(String.Format("GENERATE ,,,{0}", numberOfTransactions));
					description.AddRange(startFullStatistic.Description);
				}
				return description;
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

		public int NumberOfTransactions
		{
			get
			{
				return numberOfTransactions;
			}

			set
			{
				numberOfTransactions = value;
			}
		}

		public ClosedGenerator()
		{
			this.id = "unknown ClosedGenerator node";
		}

		public ClosedGenerator(string id)
		{
			canItHaveLabel = false;
			this.id = id;
		}

		public override StreamNodeDecorator GetNewInstanseOfIStreamNodeWithINodeData()
		{
			ClosedGenerator newNode = new ClosedGenerator();
			INode.Copy(this, newNode);
			return newNode;
		}
	}
}
