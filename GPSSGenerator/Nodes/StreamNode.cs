using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Statistics;

namespace GPSSGenerator.Nodes
{
	class StreamNode
	{
		private Node node;

		private List<StreamNode> nextNodes = new List<StreamNode>();
		private string label;
		private bool isNeedLabel = false;

		private List<Node> beforeStatistic = new List<Node>();
		private List<Node> afterStatistic = new List<Node>();

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

		public List<Node> BeforeStatistic
		{
			get
			{
				return beforeStatistic;
			}

			set
			{
				beforeStatistic = value;
			}
		}

		public List<Node> AfterStatistic
		{
			get
			{
				return afterStatistic;
			}

			set
			{
				afterStatistic = value;
			}
		}

		public List<string> buildDescription(string idOfStream)
		{
			List<string> description = new List<string>();

			for(int i = 0; i < beforeStatistic.Count; i++)
			{
				description.AddRange(beforeStatistic[i].buildDescription(idOfStream));
			}

			description.AddRange(node.buildDescription(idOfStream));

			for (int i = 0; i < afterStatistic.Count; i++)
			{
				description.AddRange(afterStatistic[i].buildDescription(idOfStream));
			}

			return description;
		}
	}
}
