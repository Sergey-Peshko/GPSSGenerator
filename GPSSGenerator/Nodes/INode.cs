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
		protected string label;
		protected bool isNeedLabel = false;
		protected List<string> description = new List<string>();
		protected bool isNeedDeclaration = false;
		protected bool canItHaveLabel = true;

		protected List<INode> nextNodes = new List<INode>();

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

		public string Label
		{
			get
			{
				return isNeedLabel ? label : "";
			}

		}

		public bool IsNeedLabel
		{
			get
			{
				return isNeedLabel;
			}

			set
			{
				isNeedLabel = value;
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

		public List<INode> NextNodes
		{
			get
			{
				return nextNodes;
			}

			set
			{
				nextNodes = value;
			}
		}
	}
}
