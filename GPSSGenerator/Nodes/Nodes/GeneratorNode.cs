using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes
{
	class GeneratorNode : INode
	{
		private string name;
		private string label;
		private bool isNeedLabel;
		private bool isNeedDeclaration;
		private string description;

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
				return label;
			}

			set
			{
				label = value;
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

		public string Description
		{
			get
			{
				return description;
			}

			set
			{
				description = value;
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
