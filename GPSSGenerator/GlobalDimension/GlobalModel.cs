using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GPSSGenerator.StreamDimension;
using GPSSGenerator.Nodes;
using GPSSGenerator.ModelReaders;
using GPSSGenerator.Statistics;

namespace GPSSGenerator.GlobalDimension
{
	public class GlobalModel
	{
		private Entity[] nodes;
		private StreamModel[] streamModels;
		private NetSettings settings = new NetSettings();
		private Statistic[] statistics;

		internal Entity[] Nodes
		{
			get
			{
				return nodes;
			}

			set
			{
				nodes = value;
			}
		}

		internal StreamModel[] StreamModels
		{
			get
			{
				return streamModels;
			}

			set
			{
				streamModels = value;
			}
		}

		internal NetSettings Settings
		{
			get
			{
				return settings;
			}
		}

		internal Statistic[] Statistics
		{
			get
			{
				return statistics;
			}

			set
			{
				statistics = value;
			}
		}

		internal GlobalModel()
		{

		}

		public List<string> MakeCode()
		{
			List<string> streams = MakeStreamsCode();
			List<string> declarations = MakeDeclarations();
			List<string> launcherCode = MakeLauncherCode();

			List<string> full = new List<string>();

			full.Add("\t ; start declarations -----------------------");
			full.AddRange(declarations);
			full.Add("\t ; end declarations -------------------------");
			full.Add("");
			full.Add("\t ; start streams code -----------------------");
			full.AddRange(streams);
			full.Add("\t ; end streams code -------------------------");
			full.Add("");
			full.Add("\t ; start launch code ------------------------");
			full.AddRange(launcherCode);
			full.Add("\t ; end launch code --------------------------");

			return full;
		}

		private List<string> MakeStreamsCode()
		{
			List<string> description = new List<string>();
			for (int i = 0; i < streamModels.Length; i++)
			{
				description.Add(string.Format("\t ; START_STREAM#{0}", i));
				description.AddRange(streamModels[i].buildStreamDescription());
				description.Add(string.Format("\t ; END_STREAM#{0}", i));
			}
			return description;
		}

		private List<string> MakeLauncherCode()
		{
			List<string> launcherCode = new List<string>();

			if (settings.IsTime)
			{
				launcherCode.Add(string.Format("GENERATE {0}", settings.NumberOfItems));
				launcherCode.Add("TERMINATE 1");
				launcherCode.Add("START 1");
			}
			else if(settings.IsTrainsactions)
			{
				launcherCode.Add(string.Format("START {0}", settings.NumberOfItems));
			}

			return launcherCode;
		}
		private List<string> MakeDeclarations()
		{
			List<string> declaration = new List<string>();

			for(int i = 0; i < nodes.Length; i++)
			{
				if(nodes[i] is IDeclarative)
				{
					declaration.AddRange(((IDeclarative)nodes[i]).buildDeclaration());
				}
			}

			return declaration;
		}

	}
}
