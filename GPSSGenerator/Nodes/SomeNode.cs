using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	class SomeNode : INode
	{
		override public string Description
		{
			get
			{
				description = "";
				description += name;
				return description;
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
