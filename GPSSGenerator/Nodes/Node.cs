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
		public abstract List<string> buildDescription(StreamModel streamModel);
	}
}
