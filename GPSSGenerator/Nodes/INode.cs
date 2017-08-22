using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	public abstract class INode
	{
		protected string id;
		protected List<string> description = new List<string>();
		protected bool isNeedDeclaration = false;
		protected bool canItHaveLabel = true;
		abstract public List<string> Description { get; }

		public string Id
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
			}
		}

		public bool CanItHaveLabel
		{
			get
			{
				return canItHaveLabel;
			}
		}

		public bool IsNeedDeclaration
		{
			get
			{
				return isNeedDeclaration;
			}

			set
			{
				isNeedDeclaration = value;
			}
		}

	}
}
