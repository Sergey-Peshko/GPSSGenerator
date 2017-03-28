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
		private string label1;
		private string label2;
		public string Description
		{
			get
			{
				description = string.Format("TRANSFER {0},{2},{1}", probability1, label1, label2);
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

		public TransferNode()
		{
			this.name = "unknown transfer node";
		}
		public TransferNode(string name)
		{
			this.name = name;
			label = string.Format("Label_{0}", name);
		}
		/*
							string name,
							double probability1,
							string label1,
							string label2
			 */
		
		public TransferNode(params Object[] param)
		{
			this.name = (string)param[0];
			this.probability1 = (double)param[1];
			this.label1 = (string)param[2];
			this.label2 = (string)param[3];
			label = string.Format("Label_{0}", name);
			//description = string.Format("{0}\tTRANSFER {1},{3},{2}", label, probability1, label1, label2);
		}
		public void SetParam(double probability1,
							string label1,
							string label2)
		{
			this.probability1 = probability1;
			this.label1 = label1;
			this.label2 = label2;
		}
	}
}
