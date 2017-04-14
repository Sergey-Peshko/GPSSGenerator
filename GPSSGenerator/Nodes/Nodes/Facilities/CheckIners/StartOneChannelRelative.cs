using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes.Facilities.CheckIners
{
	class StartOneChannelRelative : IFacility
	{
		public override string Description
		{
			get
			{
				description = String.Format("SEIZE {0}", nameOfFacility);
				return description;
			}
		}

		public StartOneChannelRelative()
		{
			this.id = "unknown StartOneChannelRelative node";
		}

		public StartOneChannelRelative(string id)
		{
			this.id = id;
			label = string.Format("Label_{0}", id);
		}
	}
}
