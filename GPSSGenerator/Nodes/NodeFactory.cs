using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Nodes;

namespace GPSSGenerator.Nodes
{
	class NodeFactory
	{
		static public List<INode> CreateNodes(string[][] nodes)
		{
			List<INode> rezult = new List<INode>(nodes.Length);
			for(int i = 0; i < nodes.Length; i++)
			{
				rezult.Add(CreateNode(nodes[i]));
			}
			SetDependencies(nodes, rezult);
			return rezult;
		}
		static private void SetDependencies(string[][] description, List<INode> nodes)
		{
			for(int i = 0; i < description.Length; i++)
			{
				if(description[i][0] == "TransferNode")
				{
					((TransferNode)nodes[i]).Node1 = nodes[FindNode(nodes, description[i][3])];
					((TransferNode)nodes[i]).Node2 = nodes[FindNode(nodes, description[i][4])];
				}
			}
		}
		static private int FindNode(List<INode> nodes, string name)
		{
			for(int i = 0; i < nodes.Count; i++)
			{
				if (nodes[i].Name == name)
					return i;
			}
			return -1;
		}
		static private INode CreateNode(string[] param)
		{
			if (param[0] == "SomeNode")
			{
				return new SomeNode(param[1]);
			}
			if (param[0] == "TransferNode")
			{
				TransferNode tmpT = new TransferNode(param[1]);
				tmpT.Probability1 = Convert.ToDouble(param[2]);
				return tmpT;
			}
			else
				throw new Exception("can't create Node");
		}
	}
}
