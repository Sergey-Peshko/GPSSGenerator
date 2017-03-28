using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator
{
	class TransferNode : INode
	{
		private string name;
		private string label;
		private bool isNeedLabel;
		private string description;
		private double probability1;
		private INode node1;
		private INode node2;
		public string Description
		{
			get
			{
				description = string.Format("TRANSFER {0},{2},{1}", probability1, node1.Label, node2.Label);
				return description;
			}

		}

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public string Label
		{
			get
			{
				return isNeedLabel ? label : "";
			}

		}

		public bool IsNeedLabel
		{
			get
			{
				return isNeedLabel;
			}

			set
			{
				isNeedLabel = value;
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

		public TransferNode()
		{
			this.name = "unknown transfer node";
		}
		public TransferNode(string name)
		{
			this.name = name;
			label = string.Format("Label_{0}", name);
		}
	}
}
