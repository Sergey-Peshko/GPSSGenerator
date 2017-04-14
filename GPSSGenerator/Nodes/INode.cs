using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	abstract class INode
	{
		protected string name;
		protected string label;
		protected bool isNeedLabel;
		protected string description;
		protected bool isNeedDeclaration;
		protected bool canItHaveLabel;

		abstract public string Description { get; }

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
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

			set
			{
				canItHaveLabel = value;
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
