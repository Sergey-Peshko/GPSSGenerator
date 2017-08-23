using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	class SomeNode : Entity, IDescribed
	{
		public List<string> Description
		{
			get
			{
				List<string>  description = new List<string>();
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
