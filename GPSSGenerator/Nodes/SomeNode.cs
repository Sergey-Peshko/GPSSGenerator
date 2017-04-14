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
				description += id;
				return description;
			}

		}

		public SomeNode()
		{
			this.id = "unknown node";
		}

		public SomeNode(string id)
		{
			this.id = id;
			label = string.Format("Lable_{0}", id);
		}
	}
}
