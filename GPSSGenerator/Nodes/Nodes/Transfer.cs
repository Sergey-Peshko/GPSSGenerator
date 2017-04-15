using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes
{
	class Transfer : INode
	{
		private double probability1;
		private INode node1;
		private INode node2;

		override public List<string> Description 
		{
			get
			{
				description.Add(string.Format("TRANSFER {0},{2},{1}", probability1, node1.Label, node2.Label));
				return description;
			}

		}

		public double Probability1
		{
			get
			{
				return probability1;
			}

			set
			{
				probability1 = value;
			}
		}

		internal INode Node1
		{
			get
			{
				return node1;
			}

			set
			{
				node1 = value;
				value.IsNeedLabel = true;
			}
		}

		internal INode Node2
		{
			get
			{
				return node2;
			}

			set
			{
				node2 = value;
				value.IsNeedLabel = true;
			}
		}

		public Transfer()
		{
			this.id = "unknown Transfer node";
		}

		public Transfer(string id)
		{
			this.id = id;
			label = string.Format("label_{0}", id);
		}
	}
}
