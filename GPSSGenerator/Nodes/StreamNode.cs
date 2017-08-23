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
		private IDescribed node;

		private List<StreamNode> nextNodes;
		private string label;
		private bool isNeedLabel = false;

		public StreamNode(IDescribed node, 
			StreamModel streamModel,
			List<StreamNode> nextNodes,
			string label)
		{
			this.node = node;
			this.streamModel = streamModel;
			this.nextNodes = nextNodes;
			this.label = label;
		}

		public List<StreamNode> NextNodes
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

		protected StreamModel StreamModel
		{
			get
			{
				return streamModel;
			}

			set
			{
				streamModel = value;
			}
		}
	}
}
