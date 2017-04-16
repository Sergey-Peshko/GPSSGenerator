using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes.Facilities
{
	class OneChannelRelative : IFacility
	{
		public override List<string> Description
		{
			get
			{
				if (description.Count == 0)
				{
					for (int i = 0; i < sStat.Count; i++)
						description.AddRange(sStat[i].Description);
					description.Add(String.Format("SEIZE {0}", id));
					description.AddRange(eStat[1].Description);
					description.Add(String.Format("ADVANCE ({0})", distribution.Description));
					description.Add(String.Format("RELEASE {0}", id));
					description.AddRange(eStat[0].Description);
				}
				return description;
			}
		}

		public OneChannelRelative()
		{
			this.id = "unknown OneChannelRelative node";
		}

		public OneChannelRelative(string id)
		{
			this.id = id;
			label = string.Format("label_{0}_STREAM#", id);
		}
	}
}
