using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes.Facilities.CheckOuters
{
	class EndOneChannelRelative : IFacility
	{
		public override string Description
		{
			get
			{
				description = String.Format("RELEASE {0}", nameOfFacility);
				return description;
			}
		}

		public EndOneChannelRelative()
		{
			this.id = "unknown EndOneChannelRelative node";
		}

		public EndOneChannelRelative(string id)
		{
			this.id = id;
			label = string.Format("Label_{0}", id);
		}
	}
}
