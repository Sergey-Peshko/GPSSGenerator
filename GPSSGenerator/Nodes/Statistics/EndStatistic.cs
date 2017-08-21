using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes
{
	class EndStatistic : INode
	{
		private string nameOfStatistic;
		public override List<string> Description
		{
			get
			{
				if (description.Count == 0)
				{
					description.Add(String.Format("DEPART {0}", nameOfStatistic));
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
		public EndStatistic()
		{
			this.id = "unknown EndStatistic node";
		}

		public EndStatistic(string id)
		{
			this.id = id;
			label = string.Format("Label_{0}", id);
		}
	}
}
