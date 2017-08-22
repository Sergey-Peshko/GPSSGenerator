using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	public class StreamNodeDecorator
	{
		protected INode node;

		protected List<StreamNodeDecorator> nextNodes = new List<StreamNodeDecorator>();
		protected string label;
		protected bool isNeedLabel = false;

		public List<StreamNodeDecorator> NextNodes
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
	}
}
