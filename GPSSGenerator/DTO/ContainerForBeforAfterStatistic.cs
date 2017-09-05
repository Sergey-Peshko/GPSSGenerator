using GPSSGenerator.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.DTO
{
	class ContainerForBeforAfterStatistic
	{
		private Node node;

		private List<Node> before = new List<Node>();
		private List<Node> after = new List<Node>();

		public ContainerForBeforAfterStatistic()
		{

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

		public List<Node> Before
		{
			get
			{
				return before;
			}

			set
			{
				before = value;
			}
		}

		public List<Node> After
		{
			get
			{
				return after;
			}

			set
			{
				after = value;
			}
		}
	}
}
