﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes
{
	interface IDeclarative
	{
		List<string> buildDeclaration();
	}
}
