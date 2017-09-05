using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPSSGenerator.GlobalDimension;
using System.Xml;
using System.Threading;

namespace UserInterface
{
	public partial class MainFrame : Form
	{

		XmlDocument doc = new XmlDocument();

		XmlNode settings;

		XmlNode entities;

		XmlNode statistics;

		XmlNode streams;


		public MainFrame()
		{
			InitializeComponent();

			XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			doc.AppendChild(docNode);

			settings = doc.CreateElement("Settings");
			entities = doc.CreateElement("Entities");
			statistics = doc.CreateElement("Statistics");
			streams = doc.CreateElement("Streams");

			entitiesDataGridView.ColumnCount = 2;
			entitiesDataGridView.Columns[0].Name = "Name of Entities";
			entitiesDataGridView.Columns[1].Name = "Type";
		}

		public void UpdateEntitiesDataGradeView()
		{
			entitiesDataGridView.Rows.Clear();

			XmlNodeList list = entities.SelectNodes("Entity");
			for(int i = 0; i < list.Count; i++)
			{
				string[] entityRow = new string[2];
				entityRow[0] = list[i].Attributes["id"]?.Value;
				entityRow[1] = list[i].Attributes["type"]?.Value;
				entitiesDataGridView.Rows.Add(entityRow);
			}

			entitiesDataGridView.AutoResizeColumns();
			entitiesDataGridView.AutoResizeRows();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			AddNode addNode = new AddNode(this);
			addNode.Show();
		}

		private void buttonAddStream_Click(object sender, EventArgs e)
		{
			StreamDescription s = new StreamDescription();
			s.Show();
		}

		private void buttonGenerate_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(GenerateCode);
			thread.Start();
		}

		public static string rez = "C:\\Users\\peshk\\Documents\\Visual Studio 2015\\Projects\\GPSSGenerator\\GPSSGenerator\\rez\\";

		public XmlNode Entities
		{
			get
			{
				return entities;
			}

			set
			{
				entities = value;
			}
		}

		public XmlNode Statistics
		{
			get
			{
				return statistics;
			}

			set
			{
				statistics = value;
			}
		}

		public XmlNode Streams
		{
			get
			{
				return streams;
			}

			set
			{
				streams = value;
			}
		}

		public XmlDocument Doc
		{
			get
			{
				return doc;
			}

			set
			{
				doc = value;
			}
		}

		private void GenerateCode()
		{
			CreateSettingsNode((int)numericValue.Value, isTime.Checked ? true : false);

			doc.Save(rez + "heh.xml");
		}

		private void CreateSettingsNode(int value, bool type)
		{
			XmlAttribute typeAttribyte = doc.CreateAttribute("measure-lifecycle-by");
			if (type)
			{
				typeAttribyte.Value = "AmountOfTime";
			}
			else
			{
				typeAttribyte.Value = "NumberOfTransactions";
			}
			XmlAttribute valueAttribute = doc.CreateAttribute("value");
			valueAttribute.Value = value.ToString();

			settings.Attributes.Append(typeAttribyte);
			settings.Attributes.Append(valueAttribute);

			doc.AppendChild(settings);
		}

		private void buttonDeleteNode_Click(object sender, EventArgs e)
		{
			XmlNodeList list = entities.SelectNodes("Entity");

			for(int i = 0; i < list.Count; i++)
			{
				if(list[i].Attributes["id"]?.Value == (string)entitiesDataGridView.CurrentRow.Cells[0].Value)
				{
					entities.RemoveChild(list[i]);
				}
			}

			UpdateEntitiesDataGradeView();
		}
	}
}
