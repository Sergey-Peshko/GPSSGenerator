using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPSSGenerator.StreamDimension;

namespace GPSSGenerator.Nodes
{
	public interface IDescribed
	{
		List<string> buildDescription(int indexOfStream);
	}
}
