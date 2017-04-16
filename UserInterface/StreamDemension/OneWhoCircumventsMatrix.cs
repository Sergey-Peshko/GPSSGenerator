using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GPSSGenerator.StreamDimension
{
	class OneWhoCircumventsMatrix
	{
		StreamWriter sw;
		public OneWhoCircumventsMatrix(StreamWriter sw)
		{
			this.sw = sw;
		}
		public void CircumventsMatrix(StreamModel m)
		{
			int[] color = new int[m.NumberOfNodes];
			dfs1(0, m, ref color);


			for (int i = 0; i < m.NumberOfNodes; i++)
			{
				if (color[i] == 0)
				{
					dfs1(i, m, ref color);
				}
			}
		}
		private void printNode(string label, List<string> description)
		{
			Console.WriteLine("{0}\t{1}", label, description[0]);
			sw.WriteLine("{0}\t{1}", label, description[0]);
			for(int i = 1; i < description.Count; i++)
			{
				Console.WriteLine("\t{0}", description[i]);
				sw.WriteLine("\t{0}", description[i]);
			}
		}
		private void dfs1(int pos, StreamModel m, ref int[] color)
		{
			color[pos] = 1;
			printNode(m.Nodes[pos].Label, m.Nodes[pos].Description);
			for (int i = 0; i < m.Graph[pos].Count; i++)
			{
				if (m.Graph[pos][i] > 0)
					if (color[i] == 0)
					{
						dfs1(i, m, ref color);
					}
			}

			for (int i = 0; i < m.Graph[pos].Count; i++)
			{
				if (color[i] == 0)
					dfs1(i, m, ref color);
			}

			color[pos] = 2;
		}
	}
}
