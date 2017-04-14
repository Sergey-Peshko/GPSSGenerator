using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes
{
	class Terminate : INode
	{
		private int count;
		public override string Description
		{
			get
			{
				description = String.Format("TERMINATE {0}", count);
				return description;
			}
		}

		public int Count
		{
			get
			{
				return count;
			}

			set
			{
				count = value;
			}
		}

		public Terminate()
		{
			this.name = "unknown Terminate node";
		}

		public Terminate(string name)
		{
			this.name = name;
			label = string.Format("Label_{0}", name);
		}
	}
}
