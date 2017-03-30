using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GPSSGenerator.GlobalDemension;

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

			nodes = new List<INode>(numberOfNodes);
			string[][] nodesDesciption = new string[numberOfNodes][];

			for (int i = 0; i < numberOfNodes; i++)
			{
				string tmp = sr.ReadLine();
				string[] tmpMass = tmp.Split(' ');
				nodesDesciption[i] = (tmpMass);
			}

			nodes = NodeFactory.CreateNodes(nodesDesciption);

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
			string tmpGpss = MakeTmpGpssCode();
			string markeredGpss = AddStreamMarkers(tmpGpss);
			string declarations = Pretreatment.MakeDeclarations(nodes, GlobalVariables.data + way);
			string finalGpss = GlueTogether(declarations, markeredGpss);
			Console.WriteLine("finalGpss in file {0}", finalGpss);
		}

		private string MakeTmpGpssCode()
		{
			string rez_way = GlobalVariables.rez + "tmpGpss" + way;
			StreamWriter sw = new StreamWriter(rez_way);
			OneWhoCircumventsMatrix circumventer = new OneWhoCircumventsMatrix(sw);
			for (int i = 0; i < matrixs.Length; i++)
			{
				Console.WriteLine("START Stream #{0}", i);
				sw.WriteLine("START Stream #{0}", i);
				circumventer.CircumventsMatrix(matrixs[i]);
				Console.WriteLine("END Stream #{0}", i);
				sw.WriteLine("END Stream #{0}", i);
				Console.WriteLine();
			}
			sw.Close();
			return rez_way;
		}
		private string AddStreamMarkers(string wayTmpGpssCode)
		{
			string rez_way = GlobalVariables.rez + "markeredGpss" + way;

			return rez_way;
		}
		private string GlueTogether(string declarations, string markeredGpss)
		{
			string rez_way = GlobalVariables.rez + way;

			return rez_way;
		}
		
	}
}
