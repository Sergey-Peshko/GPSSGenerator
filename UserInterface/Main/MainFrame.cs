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
using WinFromInterface;
using GPSSGenerator.ModelReaders;

namespace WinFromInterface
{
	public partial class MainFrame : Form
	{

		XmlDocument doc = new XmlDocument();

		XmlNode settings;

		XmlNode entities;

		XmlNode statistics;

		XmlNode streams;

		string[] entitiesIdList = new string[0];
		string[] statisticPointsIdList = new string[0];
		string[] statisticsNameList = new string[0];
		string[] streamIdList = new string[0];

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

		public string[] EntitiesIdList
		{
			get
			{
				return entitiesIdList;
			}

			set
			{
				entitiesIdList = value;
			}
		}

		public string[] StatisticsNameList
		{
			get
			{
				return statisticsNameList;
			}

			set
			{
				statisticsNameList = value;
			}
		}

		public string[] StreamIdList
		{
			get
			{
				return streamIdList;
			}

			set
			{
				streamIdList = value;
			}
		}

		public string[] StatisticPointsIdList
		{
			get
			{
				return statisticPointsIdList;
			}

			set
			{
				statisticPointsIdList = value;
			}
		}

		public MainFrame()
		{
			InitializeComponent();

			XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			doc.AppendChild(docNode);

			XmlNode model = doc.CreateElement("Model");

			settings = doc.CreateElement("Settings");
			entities = doc.CreateElement("Entities");
			statistics = doc.CreateElement("Statistics");
			streams = doc.CreateElement("Streams");

			model.AppendChild(settings);
			model.AppendChild(entities);
			model.AppendChild(statistics);
			model.AppendChild(streams);

			doc.AppendChild(model);
		}

		public void UpdateEntitiesDataGradeView()
		{
			entitiesDataGridView.Rows.Clear();

			XmlNodeList list = entities.SelectNodes("Entity");
			entitiesIdList = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				string[] entityRow = new string[2];
				entityRow[0] = list[i].Attributes["id"]?.Value;
				entitiesIdList[i] = list[i].Attributes["id"]?.Value;
				entityRow[1] = list[i].Attributes["type"]?.Value;
				entitiesDataGridView.Rows.Add(entityRow);
			}

			entitiesDataGridView.AutoResizeColumns();
			entitiesDataGridView.AutoResizeRows();
		}

		public void UpdateStatisticsDataGradeView()
		{
			statisticsDataGridView.Rows.Clear();

			XmlNodeList list = statistics.SelectNodes("Statistic");
			statisticsNameList = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				string[] statisticRow = new string[2];
				statisticRow[0] = list[i].Attributes["name"]?.Value;
				statisticsNameList[i] = list[i].Attributes["name"]?.Value;
				statisticRow[1] = list[i].Attributes["type"]?.Value;
				statisticsDataGridView.Rows.Add(statisticRow);
			}

			statisticsDataGridView.AutoResizeColumns();
			statisticsDataGridView.AutoResizeRows();
		}

		public void UpdateStreamList()
		{
			streamListBox.Items.Clear();

			XmlNodeList list = streams.SelectNodes("Stream");
			streamIdList = new string[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				streamIdList[i] = list[i].Attributes["id"]?.Value;
				streamListBox.Items.Add(streamIdList[i]);
			}
		}

		public void UpdateSettings()
		{
			numericValue.Value = Convert.ToInt32(settings.Attributes["value"]?.Value);
			if (settings.Attributes["measure-lifecycle-by"]?.Value == "AmountOfTime")
			{
				isTime.Checked = true;
			} else if (settings.Attributes["measure-lifecycle-by"]?.Value == "AmountOfTime")
			{
				isTime.Checked = false;
			}
			else
			{
				MessageBox.Show("measure-lifecycle-by unknown type");
			}
		}

		private void CreateSettingsNode()
		{
			XmlAttribute typeAttribyte = doc.CreateAttribute("measure-lifecycle-by");
			if (isTime.Checked)
			{
				typeAttribyte.Value = "AmountOfTime";
			}
			else
			{
				typeAttribyte.Value = "NumberOfTransactions";
			}
			XmlAttribute valueAttribute = doc.CreateAttribute("value");
			valueAttribute.Value = ((int)numericValue.Value).ToString();

			settings.Attributes.Append(typeAttribyte);
			settings.Attributes.Append(valueAttribute);
		}

		private List<string> GenerateCode()
		{
			CreateSettingsNode();

			GlobalModel g1 = XmlModelReader.Read(doc);

			return g1.MakeCode();
		}

		/**************************************************************/
		/**************************************************************/
		/**************************************************************/
		/**************************************************************/
		/**************************************************************/

		private void buttonAddStream_Click(object sender, EventArgs e)
		{
			if (entitiesIdList.Length > 2)
			{
				StreamForm s = new StreamForm(this);
				s.Show();
			}
			else
			{
				MessageBox.Show("You should have at least 3 entity to create Stream");
			}
		}

		private void buttonGenerate_Click(object sender, EventArgs e)
		{
			CodeForm codeForm = new CodeForm(GenerateCode());
			codeForm.Show();
		}

		private void buttonDeleteNode_Click(object sender, EventArgs e)
		{

		}

		private void addStatisticButton_Click(object sender, EventArgs e)
		{
			StatisticForm addStatistic = new StatisticForm(this);
			addStatistic.Show();
		}

		private void editStatisticButton_Click(object sender, EventArgs e)
		{
			string id = (string)statisticsDataGridView.CurrentRow.Cells[0].Value;

			XmlNodeList statisticsList = statistics.SelectNodes("Statistic");

			int i = 0;
			for (; i < statisticsList.Count; i++)
			{
				if (statisticsList[i].Attributes["name"]?.Value == id)
				{
					break;
				}
			}

			StatisticForm addStatistic = new StatisticForm(this, statisticsList[i]);
			addStatistic.Show();
		}

		private void removeStatisticButton_Click(object sender, EventArgs e)
		{
			string id = (string)statisticsDataGridView.CurrentRow.Cells[0].Value;

			XmlNodeList streamsList = streams.SelectNodes("Stream");
			for (int i = 0; i < streamsList.Count; i++)
			{
				XmlNodeList movementsList = streamsList[i].SelectSingleNode("movements").SelectNodes("movement");
				for (int j = 0; j < movementsList.Count; j++)
				{
					if (movementsList[j].HasChildNodes)
					{
						XmlNodeList statisticPointList = movementsList[j].SelectNodes("statistic");
						for (int k = 0; k < statisticPointList.Count; k++)
						{
							if (statisticPointList[k].Attributes["ref"]?.Value == id)
							{
								MessageBox.Show(string.Format(
								"Statistic {0} is still used in stream(s), " +
								"remove it from stream(s) and try again", id));
								return;
							}
						}
					}
				}

				XmlNodeList statisticPointBeforeAfterList = streamsList[i].SelectSingleNode("statistics").SelectNodes("statistic");
				for (int j = 0; j < statisticPointBeforeAfterList.Count; j++)
				{
					if (statisticPointBeforeAfterList[j].Attributes["ref"]?.Value == id)
					{
						MessageBox.Show(string.Format(
						"Statistic {0} is still used in stream(s), " +
						"remove it from stream(s) and try again", id));
						return;
					}
				}
			}

			XmlNodeList statisticsList = statistics.SelectNodes("Statistic");

			for (int i = 0; i < statisticsList.Count; i++)
			{
				if (statisticsList[i].Attributes["name"]?.Value == id)
				{
					statistics.RemoveChild(statisticsList[i]);
					break;
				}
			}
			MessageBox.Show(string.Format("Statistic {0} was removed", id));
			UpdateStatisticsDataGradeView();
		}

		private void addEntityButton_Click(object sender, EventArgs e)
		{
			EntityForm addNode = new EntityForm(this);
			addNode.Show();
		}

		private void editEntityButton_Click(object sender, EventArgs e)
		{
			string id = (string)entitiesDataGridView.CurrentRow.Cells[0].Value;

			XmlNodeList entitiesList = entities.SelectNodes("Entity");
			XmlNode toFind = null;
			for (int i = 0; i < entitiesList.Count; i++)
			{
				if (entitiesList[i].Attributes["id"]?.Value == id)
				{
					toFind = (entitiesList[i]);
					break;
				}
			}

			EntityForm editNode = new EntityForm(this, toFind);
			editNode.Show();
		}

		private void removeEntityButton_Click(object sender, EventArgs e)
		{
			string id = (string)entitiesDataGridView.CurrentRow.Cells[0].Value;

			XmlNodeList streamsList = streams.SelectNodes("Stream");
			for (int i = 0; i < streamsList.Count; i++) 
			{
				XmlNodeList movementsList = streamsList[i].SelectSingleNode("movements").SelectNodes("movement");
				for (int j = 0; j < movementsList.Count; j++) 
				{
					if((movementsList[i].Attributes["from"]?.Value == id) ||
						(movementsList[i].Attributes["to"]?.Value == id))
					{
						MessageBox.Show(string.Format(
							"Entity {0} is still used in stream(s), " +
							"remove it from stream(s) and try again", id));
						return;
					}
				}
			}

			XmlNodeList entitiesList = entities.SelectNodes("Entity");

			for (int i = 0; i < entitiesList.Count; i++)
			{
				if (entitiesList[i].Attributes["id"]?.Value == id)
				{
					entities.RemoveChild(entitiesList[i]);
					break;
				}
			}
			MessageBox.Show(string.Format("Entity {0} was removed", id));
			UpdateEntitiesDataGradeView();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				doc.Load(openFileDialog.FileName);
				if (doc.DocumentElement.Name != "Model")
				{
					MessageBox.Show("This file don't contain model");
					doc = new XmlDocument();
					return;
				}
				else
				{
					settings = doc.DocumentElement.SelectSingleNode("Settings");
					entities = doc.DocumentElement.SelectSingleNode("Entities");
					statistics = doc.DocumentElement.SelectSingleNode("Statistics");
					streams = doc.DocumentElement.SelectSingleNode("Streams");

					UpdateEntitiesDataGradeView();
					UpdateStatisticsDataGradeView();
					UpdateStreamList();
					UpdateSettings();
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				CreateSettingsNode();
				doc.Save(saveFileDialog.FileName);
			}
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Old Model was destroyed, new Model will be created");
			doc = new XmlDocument();

			XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
			doc.AppendChild(docNode);

			XmlNode model = doc.CreateElement("Model");

			settings = doc.CreateElement("Settings");
			entities = doc.CreateElement("Entities");
			statistics = doc.CreateElement("Statistics");
			streams = doc.CreateElement("Streams");

			model.AppendChild(settings);
			model.AppendChild(entities);
			model.AppendChild(statistics);
			model.AppendChild(streams);

			doc.AppendChild(model);

			UpdateEntitiesDataGradeView();
			UpdateStatisticsDataGradeView();
			UpdateStreamList();
			CreateSettingsNode();

			return;
		}

		/**************************************************************/
		/**************************************************************/
		/**************************************************************/
		/**************************************************************/
		/**************************************************************/
	}
}
