using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSSGenerator.Nodes.Nodes
{
	class QTable : INode, IDeclarative
	{
		private string nameOfStatistic;
		private int b;
		private int c;
		private int d;
		public override List<string> Description
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public List<string> Declaration
		{
			/*
				Формат: num QTAB[LE] А,В,С,D
				num - номер таблицы;
				А - номер очереди (-); 
				В - верхняя граница нижнего частотного интервала;
				С - ширина интервала; 
				D - число интервалов. 
			*/
			get
			{
				List<string> tmp = new List<string>();
				tmp.Add(String.Format("{0} QTABLE {1},{2},{3},{4}", id, nameOfStatistic, b, c, d));
				throw new NotImplementedException();
			}
		}

		public string NameOfStatistic
		{
			get
			{
				return nameOfStatistic;
			}

			set
			{
				nameOfStatistic = value;
			}
		}
		/// <summary>
		/// В - верхняя граница нижнего частотного интервала;
		/// </summary>
		public int B
		{
			get
			{
				return b;
			}

			set
			{
				b = value;
			}
		}
		/// <summary>
		/// С - ширина интервала; 
		/// </summary>
		public int C
		{
			get
			{
				return c;
			}

			set
			{
				c = value;
			}
		}
		/// <summary>
		/// D - число интервалов. 
		/// </summary>
		public int D
		{
			get
			{
				return d;
			}

			set
			{
				d = value;
			}
		}

		public QTable()
		{
			this.id = "unknown GeneratorNode node";
		}

		public QTable(string id)
		{
			isNeedDeclaration = true;
			canItHaveLabel = false;
			this.id = id;
		}
	}
}
