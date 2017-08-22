using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Statistics
{
	class StartStatistic : StreamNodeDecorator
	{
		private string nameOfStatistic;
		public override List<string> Description
		{
			get
			{
				if (description.Count == 0)
				{
					description.Add(String.Format("QUEUE {0}", nameOfStatistic));
				}
				return description;
			}
		}

		public string NameOfStatistic
		{
			get
			{
				return nameOfStatistic;
			}

			set
			{
				nameOfStatistic = value;
			}
		}

		public StartStatistic()
		{
			this.id = "unknown StartStatistic node";
		}

		public StartStatistic(string id)
		{
			this.id = id;
			label = string.Format("Label_{0}", id);
		}

		public override StreamNodeDecorator GetNewInstanseOfIStreamNodeWithINodeData()
		{
			StartStatistic newNode = new StartStatistic();
			INode.Copy(this, newNode);
			return newNode;
		}
	}
}
