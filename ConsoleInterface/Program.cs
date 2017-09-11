using System;
using System.Collections.Generic;
using System.IO;
using GPSSGenerator.GlobalDimension;
using GPSSGenerator.Nodes;
using GPSSGenerator.StreamDimension;
using System.Xml;
using GPSSGenerator.ModelReaders;

namespace ConsoleInterface
{
	class Program
	{
		//public static string data = "C:\\Users\\peshk\\Documents\\Visual Studio 2015\\Projects\\GPSSGenerator\\GPSSGenerator\\data\\";
		//public static string rez = "C:\\Users\\peshk\\Documents\\Visual Studio 2015\\Projects\\GPSSGenerator\\GPSSGenerator\\rez\\";

		static void Main(string[] args)
		{
			Console.Write("input file name: ");
			string path = Console.ReadLine();

			GlobalModel gl = XmlModelReader.Read(path);

			List<string> code = gl.MakeCode();

			for (int i = 0; i < code.Count; i++)
			{
				Console.WriteLine(code[i]);
			}

			Console.Write("input file name to save code: ");
			string pathToSave = Console.ReadLine();

			File.WriteAllLines(pathToSave, code.ToArray());
		}

	}
}
