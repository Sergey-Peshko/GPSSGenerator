using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes
{
	public class StreamNode
	{
		private Node node;

		private List<StreamNode> nextNodes = new List<StreamNode>();
		private string label;
		private bool isNeedLabel = false;

		public StreamNode(Node node, 
			string label)
		{
			this.node = node;
			this.label = label;
		}

		public List<StreamNode> NextNodes
		{
			get
			{
				return nextNodes;
			}
		}

		public string Label
		{
			get
			{
				return label;
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

		public Node Node
		{
			get
			{
				return node;
			}

			set
			{
				node = value;
			}
		}
	}
}
