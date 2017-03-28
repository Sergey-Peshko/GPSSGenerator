using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator
{
	interface INode
	{
		string Name { set; get; }
		string Label { get; }
		string Description { get; }
		bool IsNeedLabel { set; get; }
	}
}
