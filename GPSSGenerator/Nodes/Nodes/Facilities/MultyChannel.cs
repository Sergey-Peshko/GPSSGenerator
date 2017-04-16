using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes.Facilities
{
	class MultyChannel : IFacility, IDeclarative
	{
		private int numberOfChannel;
		public List<string> Declaration
		{
			get
			{
				List<string> tmp = new List<string>();
				tmp.Add(String.Format("{0} STORAGE {1}", id, numberOfChannel));
				return tmp;
			}
		}

		public override List<string> Description
		{
			get
			{
				if (description.Count == 0)
				{
					for (int i = 0; i < sStat.Count; i++)
						description.AddRange(sStat[i].Description);
					description.Add(String.Format("ENTER {0}", id));
					description.AddRange(eStat[1].Description);
					description.Add(String.Format("ADVANCE ({0})", distribution.Description));
					description.Add(String.Format("LEAVE {0}", id));
					description.AddRange(eStat[0].Description);
				}
				return description;
			}
		}

		public int NumberOfChannel
		{
			get
			{
				return numberOfChannel;
			}

			set
			{
				numberOfChannel = value;
			}
		}

		public MultyChannel()
		{
			this.id = "unknown OneChannelRelative node";
		}

		public MultyChannel(string id)
		{
			isNeedDeclaration = true;
			this.id = id;
			label = string.Format("label_{0}_STREAM#", id);
		}
	}
}
