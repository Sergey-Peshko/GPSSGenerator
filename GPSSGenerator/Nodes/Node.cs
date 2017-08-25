using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes
{
	abstract public class Node : Entity, IDescribed
	{
		public Node()
		{
			this.id = "unknown node";
		}

		public Node(string id)
		{
			this.id = id;
		}
		public abstract List<string> buildDescription(int indexOfStream);
	}
}
