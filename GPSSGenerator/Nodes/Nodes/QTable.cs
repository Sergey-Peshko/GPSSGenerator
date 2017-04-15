using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes
{
	class QTable : INode
	{
		public override List<string> Description
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public QTable()
		{
			this.id = "unknown GeneratorNode node";
		}

		public QTable(string id)
		{
			isNeedDeclaration = true;
			canItHaveLabel = false;
			this.id = id;
		}
	}
}
