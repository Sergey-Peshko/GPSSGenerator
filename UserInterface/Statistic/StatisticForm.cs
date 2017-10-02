using GPSSGenerator.GlobalDimension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFromInterface
{
	public partial class StatisticForm : Form
	{
		MainFrame mainFrame;

		Mode mode;

		XmlNode statistic;
		public StatisticForm(MainFrame mainFrame)
		{
			this.mainFrame = mainFrame;
			mode = Mode.Add;
			InitializeComponent();

			comboBoxTypeOfStatistic.DataSource = GlobalVariables.typesOfStatistics;
		}

		public StatisticForm(MainFrame mainFrame, XmlNode statistic)
		{
			this.mainFrame = mainFrame;
			mode = Mode.Edit;
			this.statistic = statistic;
			InitializeComponent();

			comboBoxTypeOfStatistic.DataSource = GlobalVariables.typesOfStatistics;

			nameTextBox.Text = statistic.Attributes["name"]?.Value;
			nameTextBox.Enabled = false;

			comboBoxTypeOfStatistic.SelectedItem = statistic.Attributes["type"]?.Value;

			if ((string)comboBoxTypeOfStatistic.SelectedItem == GlobalVariables.INTERVAL_STATISTIC)
			{
				XmlNode tableParam = statistic.SelectSingleNode("TableParam");
				if (tableParam != null)
				{
					tableParamDataGridView.Rows[0].Cells[0].Value = tableParam.Attributes["UpperBoundOfLowerFrequencyInterval"]?.Value;
					tableParamDataGridView.Rows[0].Cells[1].Value = tableParam.Attributes["IntervalWidth"]?.Value;
					tableParamDataGridView.Rows[0].Cells[2].Value = tableParam.Attributes["NumberOfIntervals"]?.Value;
				}
			}
			else if ((string)comboBoxTypeOfStatistic.SelectedItem == GlobalVariables.ONEPOINT_STATISTIC)
			{
				XmlNode tableParam = statistic.SelectSingleNode("TableParam");
				if (tableParam != null)
				{
					tableParamDataGridView.Rows[0].Cells[0].Value = tableParam.Attributes["UpperBoundOfLowerFrequencyInterval"]?.Value;
					tableParamDataGridView.Rows[0].Cells[1].Value = tableParam.Attributes["IntervalWidth"]?.Value;
					tableParamDataGridView.Rows[0].Cells[2].Value = tableParam.Attributes["NumberOfIntervals"]?.Value;
				}
			}
			else
			{
				throw new Exception("can't understand type of node");
			}
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			try
			{

				if (nameTextBox.Text == "")
				{
					MessageBox.Show("name of statistic can't be empty");
					return;
				}
				if (mode == Mode.Add)
				{
					XmlNodeList xmlStatistics = mainFrame.Statistics.SelectNodes("Statistic");

					for (int i = 0; i < xmlStatistics.Count; i++)
					{
						if (xmlStatistics[i].Attributes["name"]?.Value == nameTextBox.Text)
						{
							MessageBox.Show("name of statistic should be unique");
							return;
						}
					}
				}

				XmlNode newStatistic = mainFrame.Doc.CreateElement("Statistic");

				XmlAttribute statisticId = mainFrame.Doc.CreateAttribute("name");
				statisticId.Value = nameTextBox.Text;
				XmlAttribute statisticType = mainFrame.Doc.CreateAttribute("type");
				statisticType.Value = (string)comboBoxTypeOfStatistic.SelectedItem;

				newStatistic.Attributes.Append(statisticId);
				newStatistic.Attributes.Append(statisticType);

				if ((string)comboBoxTypeOfStatistic.SelectedItem == GlobalVariables.INTERVAL_STATISTIC)
				{
					newStatistic.AppendChild(GetTableParamNode());
				}
				else if ((string)comboBoxTypeOfStatistic.SelectedItem == GlobalVariables.ONEPOINT_STATISTIC)
				{
					newStatistic.AppendChild(GetTableParamNode());
				}
				else
				{
					throw new Exception("can't understand type of statistic");
				}

				if (mode == Mode.Add)
				{
					mainFrame.Statistics.AppendChild(newStatistic);
				}
				else
				{
					mainFrame.Statistics.ReplaceChild(newStatistic, statistic);
				}

				mainFrame.UpdateStatisticsDataGradeView();

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wrong in definition, change it and try again!");
			}
		}

		private XmlNode GetTableParamNode()
		{
			XmlNode tableParam = mainFrame.Doc.CreateElement("TableParam");
			XmlAttribute upperBoundOfLowerFrequencyIntervalAttr = mainFrame.Doc.CreateAttribute("UpperBoundOfLowerFrequencyInterval");
			upperBoundOfLowerFrequencyIntervalAttr.Value = Convert.ToUInt32(tableParamDataGridView.Rows[0].Cells[0].Value).ToString();
			XmlAttribute intervalWidthAttr = mainFrame.Doc.CreateAttribute("IntervalWidth");
			intervalWidthAttr.Value = Convert.ToUInt32(tableParamDataGridView.Rows[0].Cells[1].Value).ToString();
			XmlAttribute numberOfIntervalsAttr = mainFrame.Doc.CreateAttribute("NumberOfIntervals");
			numberOfIntervalsAttr.Value = Convert.ToUInt32(tableParamDataGridView.Rows[0].Cells[2].Value).ToString();

			tableParam.Attributes.Append(upperBoundOfLowerFrequencyIntervalAttr);
			tableParam.Attributes.Append(intervalWidthAttr);
			tableParam.Attributes.Append(numberOfIntervalsAttr);

			return tableParam;
		}

		private void comboBoxTypeOfStatistic_SelectedIndexChanged(object sender, EventArgs e)
		{
			tabControl.TabPages.Clear();

			if ((string)comboBoxTypeOfStatistic.SelectedItem == GlobalVariables.INTERVAL_STATISTIC)
			{
				tabControl.TabPages.Add(tableParamTabPage);
				tableParamDataGridView.Rows.Clear();
				tableParamDataGridView.Rows.Add();
			}
			else if ((string)comboBoxTypeOfStatistic.SelectedItem == GlobalVariables.ONEPOINT_STATISTIC)
			{
				tabControl.TabPages.Add(tableParamTabPage);
				tableParamDataGridView.Rows.Clear();
				tableParamDataGridView.Rows.Add();
			}
			else
			{
				throw new Exception("can't understand type of node");
			}
		}

		private void TuneOnTableParamDataGridView()
		{
			tableParamDataGridView.ColumnCount = 3;
			tableParamDataGridView.Columns[0].Name = "Upper Bound Of Lower Frequency Interval";
			tableParamDataGridView.Columns[1].Name = "Interval Width";
			tableParamDataGridView.Columns[2].Name = "Number Of Intervals";

		}
	}
}
