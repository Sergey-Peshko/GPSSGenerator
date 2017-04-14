using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes.Facilities
{
	abstract class IFacility : INode
	{
		protected string nameOfFacility;

		public string NameOfFacility
		{
			get
			{
				return nameOfFacility;
			}

			set
			{
				nameOfFacility = value;
			}
		}
	}
}
