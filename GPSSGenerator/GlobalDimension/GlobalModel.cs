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
		private Entity[] nodes;
		private StreamModel[] streamModels;
		private NetSettings settings = new NetSettings();

		public Entity[] Nodes
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

		public StreamModel[] StreamModels
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

		public GlobalModel()
		{

		}

		public GlobalModel(Entity[] nodes, StreamModel[] streamModels, NetSettings settings)
		{
			this.nodes = nodes;
			this.streamModels = streamModels;
			this.settings = settings;
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
				launcherCode.Add(string.Format("GENERATE {0}", settings.AmountOfTime));
				launcherCode.Add("TERMINATE 1");
				launcherCode.Add("START 1");
			}
			else if(settings.IsTrainsactions)
			{
				launcherCode.Add(string.Format("START {0}", settings.NumberOfTransactions));
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
