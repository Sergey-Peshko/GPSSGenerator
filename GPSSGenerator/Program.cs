using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GPSSGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("input file name: ");
			string way = Console.ReadLine();
			GlobalModel gl = new GlobalModel(way);
			gl.Read();
			gl.MakeCode();
			
		}
	}
}
