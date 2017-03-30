using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.GlobalDemension
{
	class Pretreatment
	{
		public static string MakeDeclarations(List<INode> nodes, string way)
		{
			string rez_way = GlobalVariables.rez + "declarations" + way;

			return rez_way;
		}
		/*
		private int InsertTransfers(int currNode)
		{
			List<KeyValuePair<int, double>> transitions = new List<KeyValuePair<int, double>>();
			for (int i=0; i < graph[currNode].Count; i++)
			{
				if (graph[currNode][i] > 0 && graph[currNode][i] < 1)
				{
					transitions.Add(new KeyValuePair<int, double>(i, graph[currNode][i]));
					nodes[i].IsNeedLabel = true;
				}
			}
			double remainingPersents = 1;
			TransferNode[] transfers = new TransferNode[transitions.Count - 1];
			for(int i=0;i< transfers.Length; i++)
			{
				transfers[i] = new TransferNode(string.Format("T{0}", GlobalVariables.counterOfTransfers++));
				if (i > 0)
					transfers[i].IsNeedLabel = true;
			}
			List<List<double>> insertlinks = new List<List<double>>();
			for (int i = 0; i < transitions.Count - 1; i++)
			{
				double percents = (double)(transitions[i].Value * 1) / remainingPersents;
				remainingPersents -= transitions[i].Value;
				transfers[i].SetParam(percents,
					String.Format("Stream_{0}", index) + nodes[transitions[i].Key].Label,
					i == transitions.Count - 2 ?
					String.Format("Stream_{0}", index) + nodes[transitions[transitions.Count - 1].Key].Label :
					String.Format("Stream_{0}", index) + transfers[i + 1].Label
					);
				
				nodes[transitions[i].Key].IsNeedLabel = true;

				List<double> tmp = new List<double>();
				
				for(int ii = 0; ii < (graph.Count + transitions.Count - 1); ii++)
				{
					tmp.Add(0);
				}
				tmp[transitions[i].Key] = percents;
				tmp[i == transitions.Count - 2 ?
					transitions[transitions.Count - 1].Key :
					transitions[i].Key + 1] = 1 - percents;

				
				insertlinks.Add(tmp);

			}

			for (int i = 0; i < graph.Count; i++)
			{
				graph[i].InsertRange(graph.Count, new double[transitions.Count - 1]);
			}

			for (int i = 0; i < graph[currNode].Count; i++) 
			{
				graph[currNode][i] = 0;
			}

			graph[currNode][graph.Count] = 1;

			nodes.InsertRange(nodes.Count, transfers);
			graph.InsertRange(graph.Count, insertlinks);

			return transfers.Length;
		}
		*/
	}
}
