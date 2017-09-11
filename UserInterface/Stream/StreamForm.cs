using GPSSGenerator.GlobalDimension;
using System;
using System.Collections;
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
	public partial class StreamForm : Form
	{
		MainFrame mainFrame;

		XmlNode movements;

		XmlNode statistics;

		XmlNode stream;

		Mode mode;

		List<FromTo> fromToList = new List<FromTo>();
		Dictionary<string, uint> nodeSet = new Dictionary<string, uint>();

		public StreamForm(MainFrame mainFrame)
		{
			this.mainFrame = mainFrame;
			mode = Mode.Add;

			InitializeComponent();

			movements = mainFrame.Doc.CreateElement("movements");
			statistics = mainFrame.Doc.CreateElement("statistics");

			fromComboBox.DataSource = mainFrame.EntitiesIdList.Clone();
			toComboBox.DataSource = mainFrame.EntitiesIdList.Clone();
			statisticNameComboBox.DataSource = mainFrame.StatisticsNameList.Clone();
		}

		public StreamForm(MainFrame mainFrame, XmlNode stream)
		{
			this.mainFrame = mainFrame;
			this.stream = stream;
			mode = Mode.Edit;
			InitializeComponent();

			streamIdTextBox.Text = stream.Attributes["id"]?.Value;

			streamIdTextBox.Enabled = false;

			movements = stream.SelectSingleNode("movements");
			UpdateMovementsDataGridView();
			statistics = stream.SelectSingleNode("statistics");

			fromComboBox.DataSource = mainFrame.EntitiesIdList.Clone();
			toComboBox.DataSource = mainFrame.EntitiesIdList.Clone();
			statisticNameComboBox.DataSource = mainFrame.StatisticsNameList.Clone();

			UpdateStatisticBetweenDataGridView();
			UpdateStatisticBeforeDataGridView();
			UpdateStatisticAfterDataGridView();
		}

		private void UpdateStatisticBeforeDataGridView()
		{
			statisticBeforeDataGridView.Rows.Clear();

			XmlNodeList statisticsList = statistics.SelectNodes("statistic");
			for (int i = 0; i < statisticsList.Count; i++) 
			{
				if(statisticsList[i].Attributes["before"]?.Value != null)
				{
					string[] row = new string[3];

					row[0] = statisticsList[i].Attributes["id"]?.Value;
					row[1] = statisticsList[i].Attributes["ref"]?.Value;
					row[2] = statisticsList[i].Attributes["before"]?.Value;
					statisticBeforeDataGridView.Rows.Add(row);
				}
			}
		}

		private void UpdateStatisticAfterDataGridView()
		{
			statisticAfterDataGridView.Rows.Clear();

			XmlNodeList statisticsList = statistics.SelectNodes("statistic");
			for (int i = 0; i < statisticsList.Count; i++)
			{
				if (statisticsList[i].Attributes["after"]?.Value != null)
				{
					string[] row = new string[3];

					row[0] = statisticsList[i].Attributes["id"]?.Value;
					row[1] = statisticsList[i].Attributes["ref"]?.Value;
					row[2] = statisticsList[i].Attributes["after"]?.Value;
					statisticAfterDataGridView.Rows.Add(row);
				}
			}
		}

		private void UpdateStatisticBetweenDataGridView()
		{
			statisticBetweenDataGridView.Rows.Clear();

			XmlNodeList movementsList = movements.SelectNodes("movement");
			for (int i = 0; i < movementsList.Count; i++)
			{
				if (movementsList[i].HasChildNodes)
				{
					XmlNodeList movementStatisticPointsList = movementsList[i].SelectNodes("statistic");
					for (int j = 0; j < movementStatisticPointsList.Count; j++)
					{
						string[] row = new string[3];

						row[0] = movementStatisticPointsList[j].Attributes["id"]?.Value;
						row[1] = movementStatisticPointsList[j].Attributes["ref"]?.Value;
						row[2] = movementsList[i].Attributes["from"]?.Value + ' ' + movementsList[i].Attributes["to"]?.Value;
						statisticBetweenDataGridView.Rows.Add(row);
					}
				}
			}
		}

		public void UpdateMovementsDataGridView()
		{
			movementsDataGridView.Rows.Clear();

			XmlNodeList movementsList = movements.SelectNodes("movement");

			nodeSet.Clear();
			fromToList.Clear();

			for (int i = 0; i < movementsList.Count; i++)
			{
				string[] row = new string[3];

				FromTo fromTo = new FromTo();
				fromTo.From = movementsList[i].Attributes["from"]?.Value;
				fromTo.To = movementsList[i].Attributes["to"]?.Value;

				fromToList.Add(fromTo);

				if (nodeSet.ContainsKey(movementsList[i].Attributes["from"]?.Value))
				{
					nodeSet[movementsList[i].Attributes["from"]?.Value] += (uint)((Convert.ToDouble(movementsList[i].Attributes["value"]?.Value) * 100));
				}
				else
				{
					nodeSet.Add(movementsList[i].Attributes["from"]?.Value, (uint)((Convert.ToDouble(movementsList[i].Attributes["value"]?.Value) * 100)));
				}

				if (!nodeSet.ContainsKey(movementsList[i].Attributes["to"]?.Value))
				{
					nodeSet.Add(movementsList[i].Attributes["to"]?.Value, 0);
				}

				row[0] = movementsList[i].Attributes["from"]?.Value;
				row[1] = movementsList[i].Attributes["to"]?.Value;
				row[2] = (Convert.ToDouble(movementsList[i].Attributes["value"]?.Value) * 100).ToString();

				movementsDataGridView.Rows.Add(row);
			}

			string[] participalNodes = new string[nodeSet.Keys.Count];
			nodeSet.Keys.CopyTo(participalNodes, 0);
			string[] movementsAsString = new string[fromToList.Count];
			for (int i = 0; i < movementsAsString.Length; i++)
			{
				movementsAsString[i] = string.Format("{0} {1}", fromToList[i].From, fromToList[i].To);
			}

			beforeComboBox.DataSource = participalNodes.Clone();
			afterComboBox.DataSource = participalNodes.Clone();
			betweenComboBox.DataSource = movementsAsString.Clone();
		}

		/**Stream************************************************************/

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			IEnumerator<KeyValuePair<string, uint>> nodeSetIterator = nodeSet.GetEnumerator();

			while (nodeSetIterator.MoveNext())
			{
				if(!(nodeSetIterator.Current.Value == 0 ||
					nodeSetIterator.Current.Value == 100))
				{
					MessageBox.Show("Check your probabilities");
					return;
				}

				if (nodeSetIterator.Current.Value == 0)
				{
					XmlNodeList entitiesList = mainFrame.Entities.SelectNodes("Entity");
					for (int i = 0; i < entitiesList.Count; i++) 
					{
						if(entitiesList[i].Attributes["id"]?.Value == nodeSetIterator.Current.Key)
						{
							if(entitiesList[i].Attributes["type"]?.Value != GlobalVariables.RECEIVER)
							{
								MessageBox.Show("Only RECEIVER can haven't continuation");
								return;
							}
						}
					}
				}
			}

			if (streamIdTextBox.Text == "")
			{
				MessageBox.Show("Stream should have id");
				return;
			}


			if (mode == Mode.Add)
			{
				XmlNodeList xmlStreams = mainFrame.Streams.SelectNodes("Stream");

				for (int i = 0; i < xmlStreams.Count; i++)
				{
					if (xmlStreams[i].Attributes["id"]?.Value == streamIdTextBox.Text)
					{
						MessageBox.Show("Stream id should uniqie");
						return;
					}
				}
			}

			XmlNode newStream = mainFrame.Doc.CreateElement("Stream");
			XmlAttribute id = mainFrame.Doc.CreateAttribute("id");

			id.Value = streamIdTextBox.Text;
			newStream.Attributes.Append(id);

			newStream.AppendChild(movements);
			newStream.AppendChild(statistics);

			if (mode == Mode.Add)
			{
				mainFrame.Streams.AppendChild(newStream);
			}
			else
			{
				mainFrame.Streams.ReplaceChild(newStream, stream);
			}

			mainFrame.UpdateStreamList();

			this.Close();
		}

		/**Stream************************************************************/

		/**Movement************************************************************/

		private void addMovementButton_Click(object sender, EventArgs e)
		{
			if ((string)fromComboBox.SelectedValue == (string)toComboBox.SelectedValue)
			{
				MessageBox.Show("from and to entity should be different");
				return;
			}

			FromTo fromTo = new FromTo();
			fromTo.From = (string)fromComboBox.SelectedValue;
			fromTo.To = (string)toComboBox.SelectedValue;

			if (fromToList.Contains(fromTo))
			{
				MessageBox.Show("You have already had such movement, " + 
					"if you want to change probability, please delete current " + 
					"add insert one more!");
				return;
			}

			if (nodeSet.ContainsKey((string)fromComboBox.SelectedValue))
			{
				if ((nodeSet[(string)fromComboBox.SelectedValue] +
									(probabilityNumericUpDown.Value)) > 100)
				{
					MessageBox.Show("Check remain from-entity probability to output");
					return;
				}
			}

			XmlNode movement = mainFrame.Doc.CreateElement("movement");
			XmlAttribute fromAttr = mainFrame.Doc.CreateAttribute("from");
			fromAttr.Value = (string)fromComboBox.SelectedValue;
			XmlAttribute toAttr = mainFrame.Doc.CreateAttribute("to");
			toAttr.Value = (string)toComboBox.SelectedValue;
			XmlAttribute valueAttr = mainFrame.Doc.CreateAttribute("value");
			valueAttr.Value = Convert.ToString(probabilityNumericUpDown.Value / 100);
			movement.Attributes.Append(fromAttr);
			movement.Attributes.Append(toAttr);
			movement.Attributes.Append(valueAttr);

			movements.AppendChild(movement);

			UpdateMovementsDataGridView();
		}

		private void removeMovementButton_Click(object sender, EventArgs e)
		{
			string from = (string)movementsDataGridView.CurrentRow.Cells[0].Value;
			string to = (string)movementsDataGridView.CurrentRow.Cells[1].Value;

			XmlNodeList movementsList = movements.SelectNodes("movement");

			for (int i = 0; i < movementsList.Count; i++)
			{
				if ((movementsList[i].Attributes["from"]?.Value == from) &&
					(movementsList[i].Attributes["to"]?.Value == to))
				{
					movements.RemoveChild(movementsList[i]);
					break;
				}
			}

			UpdateMovementsDataGridView();
		}

		/**Movement************************************************************/

		/**Statistic************************************************************/

		private bool CheckStatisticIdUniqueAmongStatistics(string id)
		{
			XmlNodeList statisticsList = statistics.SelectNodes("statistic");
			for (int i = 0; i < statisticsList.Count; i++)
			{
				if (statisticsList[i].Attributes["id"]?.Value == id)
				{
					return true;
				}
			}

			XmlNodeList movementsList = movements.SelectNodes("movement");
			for (int i = 0; i < movementsList.Count; i++)
			{
				if (movementsList[i].HasChildNodes)
				{
					XmlNodeList statisticsMovementPointList = movementsList[i].SelectNodes("statistic");
					for (int j = 0; j < statisticsMovementPointList.Count; j++)
					{
						if (statisticsMovementPointList[j].Attributes["id"]?.Value == id)
						{
							return true;
						}
					}
				}
			}

			return false;
		}

		private XmlNode BuildGeneralStatisticPointInfo()
		{
			if (statisticIdTextBox.Text == "")
			{
				MessageBox.Show("Statistic Point should have id");
				return null;
			}
			if (mainFrame.EntitiesIdList.Contains(statisticIdTextBox.Text) ||
				CheckStatisticIdUniqueAmongStatistics(statisticIdTextBox.Text))
			{
				MessageBox.Show("Statistic Point Id should have unique, among entities and statistic points");
				return null;
			}

			XmlNode statisticPoint = mainFrame.Doc.CreateElement("statistic");
			XmlAttribute statisticPointIdAtrr = mainFrame.Doc.CreateAttribute("id");
			statisticPointIdAtrr.Value = statisticIdTextBox.Text;
			XmlAttribute statisticPointRefAtrr = mainFrame.Doc.CreateAttribute("ref");
			statisticPointRefAtrr.Value = (string)statisticNameComboBox.SelectedItem;

			statisticPoint.Attributes.Append(statisticPointIdAtrr);
			statisticPoint.Attributes.Append(statisticPointRefAtrr);

			return statisticPoint;
		}

		private void addStatisticButton_Click(object sender, EventArgs e)
		{
			if (putSstatisticPointBeforeRadioButton.Checked)
			{
				XmlNode statisticPoint = BuildGeneralStatisticPointInfo();
				if(statisticPoint == null)
				{
					return;
				}

				XmlAttribute statisticPointBeforeAttr = 
					mainFrame.Doc.CreateAttribute("before");
				statisticPointBeforeAttr.Value = (string)beforeComboBox.SelectedItem;
				statisticPoint.Attributes.Append(statisticPointBeforeAttr);

				statistics.AppendChild(statisticPoint);

				UpdateStatisticBeforeDataGridView();

			} else if (putStatisticPointAfterRadioButton.Checked)
			{
				XmlNode statisticPoint = BuildGeneralStatisticPointInfo();
				if (statisticPoint == null)
				{
					return;
				}

				XmlAttribute statisticPointAfterAttr =
					mainFrame.Doc.CreateAttribute("after");
				statisticPointAfterAttr.Value = (string)beforeComboBox.SelectedItem;
				statisticPoint.Attributes.Append(statisticPointAfterAttr);

				statistics.AppendChild(statisticPoint);

				UpdateStatisticAfterDataGridView();

			} else if (putStatisticPointBetweenRadioButton.Checked)
			{
				XmlNode statisticPoint = BuildGeneralStatisticPointInfo();
				if (statisticPoint == null)
				{
					return;
				}

				string[] mass = ((string)betweenComboBox.SelectedItem).Split(' ');
				string from = mass[0];
				string to = mass[1];

				XmlNodeList movementsList = movements.SelectNodes("movement");
				for (int i = 0; i < movementsList.Count; i++)
				{
					if((movementsList[i].Attributes["from"]?.Value == from) &&
							(movementsList[i].Attributes["to"]?.Value == to))
					{
						movementsList[i].AppendChild(statisticPoint);
						break;
					}
				}

				UpdateStatisticBetweenDataGridView();

			}
			else
			{
				MessageBox.Show("Please select any radio button");
			}
		}

		private void removeStatisticBeforeButton_Click(object sender, EventArgs e)
		{
			string id = (string)statisticBeforeDataGridView.CurrentRow.Cells[0].Value;

			XmlNodeList statisticsList = statistics.SelectNodes("statistic");
			for (int i = 0; i < statisticsList.Count; i++) 
			{
				if(statisticsList[i].Attributes["id"]?.Value == id)
				{
					statistics.RemoveChild(statisticsList[i]);
					UpdateStatisticBeforeDataGridView();
					return;
				}
			}
		}

		private void removeStatisticAfterButton_Click(object sender, EventArgs e)
		{
			string id = (string)statisticAfterDataGridView.CurrentRow.Cells[0].Value;

			XmlNodeList statisticsList = statistics.SelectNodes("statistic");
			for (int i = 0; i < statisticsList.Count; i++)
			{
				if (statisticsList[i].Attributes["id"]?.Value == id)
				{
					statistics.RemoveChild(statisticsList[i]);
					UpdateStatisticAfterDataGridView();
					return;
				}
			}
		}

		private void removeStatisticBetweenButton_Click(object sender, EventArgs e)
		{
			string id = (string)statisticBetweenDataGridView.CurrentRow.Cells[0].Value;

			XmlNodeList movementsList = movements.SelectNodes("movement");
			for (int i = 0; i < movementsList.Count; i++)
			{
				if (movementsList[i].HasChildNodes)
				{
					XmlNodeList statisticsMovementPointList = movementsList[i].SelectNodes("statistic");
					for (int j = 0; j < statisticsMovementPointList.Count; j++) 
					{
						if (statisticsMovementPointList[j].Attributes["id"]?.Value == id)
						{
							movementsList[i].RemoveChild(statisticsMovementPointList[j]);
							UpdateStatisticBetweenDataGridView();
							return;
						}
					}
				}
			}
		}

		/**Statistic************************************************************/


		private class FromTo
		{
			string from;
			string to;

			public FromTo()
			{

			}

			public string From
			{
				get
				{
					return from;
				}

				set
				{
					from = value;
				}
			}

			public string To
			{
				get
				{
					return to;
				}

				set
				{
					to = value;
				}
			}

			// override object.Equals
			public override bool Equals(object obj)
			{
				if (obj == null || GetType() != obj.GetType())
				{
					return false;
				}

				return ((from == ((FromTo)obj).from) && (to == ((FromTo)obj).to));
			}

			// override object.GetHashCode
			public override int GetHashCode()
			{
				return from.GetHashCode() * to.GetHashCode();
			}
		}

		private void putSstatisticPointBeforeRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			beforeComboBox.Enabled = putSstatisticPointBeforeRadioButton.Checked;
		}

		private void putStatisticPointAfterRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			afterComboBox.Enabled = putStatisticPointAfterRadioButton.Checked;
		}

		private void putStatisticPointBetweenRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			betweenComboBox.Enabled = putStatisticPointBetweenRadioButton.Checked;
		}
	}
}
