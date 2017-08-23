using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Nodes;

namespace GPSSGenerator.GlobalDimension
{
	public class GlobalModel
	{
		private List<Entity> entities;
		private List<StreamModel> streamModels;
		private NetSettings settings;

		public NetSettings Settings
		{
			get
			{
				return settings;
			}

			set
			{
				settings = value;
			}
		}

		public List<StreamModel> StreamModels
		{
			get
			{
				return streamModels;
			}

		}

		public GlobalModel()
		{
			nodes = new List<Entity>();
			streamModels = new List<StreamModel>();
		}
		public GlobalModel(string way) { this.way = way; }

		public void MakeCode()
		{
			string tmpGpss = MakeTmpGpssCode();
			string markeredGpss = AddStreamMarkers(tmpGpss);
			string declarations = MakeDeclarations();
			string finalGpss = GlueTogether(declarations, markeredGpss);
			//добавить START
			//Console.WriteLine("finalGpss in file {0}", finalGpss);
		}

		private string MakeTmpGpssCode()
		{
			string rez_way = GlobalVariables.rez + "tmpGpss" + way;
			StreamWriter sw = new StreamWriter(rez_way);
			OneWhoCircumventsMatrix circumventer = new OneWhoCircumventsMatrix(sw);
			for (int i = 0; i < streamModels.Count; i++)
			{
				Console.WriteLine("START_STREAM#{0}", i);
				sw.WriteLine("START_STREAM#{0}", i);
				circumventer.CircumventsMatrix(streamModels[i]);
				Console.WriteLine("END_STREAM#{0}", i);
				sw.WriteLine("END_STREAM#{0}", i);
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
		private string MakeDeclarations()
		{
			string rez_way = GlobalVariables.rez + "declarations" + way;

			return rez_way;
		}

	}
}
