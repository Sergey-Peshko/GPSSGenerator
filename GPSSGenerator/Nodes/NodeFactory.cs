using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator
{
	class NodeFactory
	{
		static public INode CreateNode(string type, Object[] param)
		{
			if (type == "SomeNode")
				return new SomeNode(param);
			if (type == "TransferNode")
				return new TransferNode(param);
			else
				throw new Exception("can't create Node");
		}
	}
}
