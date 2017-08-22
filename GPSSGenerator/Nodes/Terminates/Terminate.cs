using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Statistics;

namespace GPSSGenerator.Nodes.Terminates
{
	class Terminate : StreamNodeDecorator
	{
		private int count;
		private EndStatistic endFullStatistic;
		public override List<string> Description
		{
			get
			{
				if (description.Count == 0)
				{
					description.AddRange(endFullStatistic.Description);
					description.Add(String.Format("TERMINATE {0}", count));
				}
				return description;
			}
		}

		public int Count
		{
			get
			{
				return count;
			}

			set
			{
				count = value;
			}
		}

		public EndStatistic EndFullStatistic
		{
			get
			{
				return endFullStatistic;
			}

			set
			{
				endFullStatistic = value;
			}
		}
		public Terminate()
		{
			this.id = "unknown Terminate node";
		}

		public Terminate(string id)
		{
			this.id = id;
			label = string.Format("label_{0}_STREAM#", id);
		}

		public override StreamNodeDecorator GetNewInstanseOfIStreamNodeWithINodeData()
		{
			Terminate terminate = new Terminate();
			INode.Copy(this, terminate);
			return terminate;
		}
	}
}
