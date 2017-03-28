using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator
{
	class SomeNode : INode
	{
		private string name;
		private string description;
		private string label;
		private bool isNeedLabel;
		public string Description
		{
			get
			{
				description = "";
				description += name;
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
				return label;
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
		public SomeNode()
		{
			this.name = "unknown node";
		}
		public SomeNode(string name)
		{
			this.name = name;
			label = string.Format("Lable_{0}", name);
		}
	}
}
