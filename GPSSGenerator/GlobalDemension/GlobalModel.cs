using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GPSSGenerator
{
	class GlobalModel
	{
		private List<INode> nodes;
		private StreamModel[] matrixs;

		private string way;
		public GlobalModel(string way) { this.way = way; }


		public void Read()
		{
			StreamReader sr = new StreamReader(
				GlobalVariables.data + way);
			int numberOfNodes = Convert.ToInt32(sr.ReadLine());

			nodes = new List<INode>();
			List<string> nodesDesciption = new List<string>();

			for (int i = 0; i < numberOfNodes; i++)
			{
				string tmp = sr.ReadLine();
				nodesDesciption.Add(tmp);
				string[] mass = tmp.Split(' ');
				Object[] param = new Object[mass.Length - 1];
				Array.Copy(mass, 1, param, 0, param.Length);
				nodes.Add(NodeFactory.CreateNode(mass[0], param));
			}

			int count = Convert.ToInt32(sr.ReadLine());
			matrixs = new StreamModel[count];

			for (int i = 0; i < count; i++)
			{
				matrixs[i] = new StreamModel(i);
				matrixs[i].Read(ref sr, nodes);
			}

		}
		public void MakeCode()
		{
			StreamWriter sw = new StreamWriter(GlobalVariables.rez + way);
			OneWhoCircumventsMatrix circumventer = new OneWhoCircumventsMatrix(sw);
			for (int i = 0; i < matrixs.Length; i++)
			{
				Console.WriteLine("Coments: Stream {0}", i);
				sw.WriteLine("Coments: Stream {0}", i);
				circumventer.CircumventsMatrix(matrixs[i]);
			}
			sw.Close();
		}
		
	}
}
