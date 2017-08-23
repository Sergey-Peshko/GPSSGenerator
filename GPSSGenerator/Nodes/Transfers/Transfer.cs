using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes.Transfers
{
	class Transfer : Node
	{
		private float probability1;
		private StreamNode node1;
		private StreamNode node2;

		public float Probability1
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

		internal StreamNode Node1
		{
			get
			{
				return node1;
			}

			set
			{
				node1 = value;
			}
		}

		internal StreamNode Node2
		{
			get
			{
				return node2;
			}

			set
			{
				node2 = value;
			}
		}

		public Transfer()
		{
			this.id = "unknown Transfer node";
		}

		public Transfer(string id)
		{
			this.id = id;
		}

		public override List<string> buildDescription(StreamModel streamModel)
		{
			List<string> description = new List<string>();

			description.Add(string.Format("TRANSFER {0},{2},{1}", probability1, node1.Label, node2.Label));

			return description;
		}
	}
}
