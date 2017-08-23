using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	public abstract class Entity
	{
		protected string id;

		public string Id
		{
			get
			{
				return id;
			}
		}

	}
}
