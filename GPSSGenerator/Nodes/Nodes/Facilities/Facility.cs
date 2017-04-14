using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.Nodes.Distributions;
using GPSSGenerator.Nodes.Nodes.Facilities;

namespace GPSSGenerator.Nodes.Nodes.Facilities
{
	class Facility : INode
	{
		private IDistribution distribution;
		private INode checkIner;
		private INode checkOuter;

		public override string Description
		{
			get
			{
				description = String.Format("ADVANCE ({0})", distribution.Description);
				return description;
			}
		}

		public IDistribution Distribution
		{
			get
			{
				return distribution;
			}

			set
			{
				distribution = value;
			}
		}

		public INode CheckOuter
		{
			get
			{
				return checkOuter;
			}

			set
			{
				checkOuter = value;
			}
		}

		public INode CheckIner
		{
			get
			{
				return checkIner;
			}

			set
			{
				checkIner = value;
			}
		}

		public Facility()
		{
			this.name = "unknown node";
		}

		public Facility(string name)
		{
			this.name = name;
			label = string.Format("Lable_{0}", name);
		}
	}
}
