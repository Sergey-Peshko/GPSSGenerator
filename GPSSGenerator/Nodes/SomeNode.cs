using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	class SomeNode : INode
	{
		override public List<string> Description
		{
			get
			{
				description = new List<string>();
				description.Add("" + id);
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
		}
	}
}
