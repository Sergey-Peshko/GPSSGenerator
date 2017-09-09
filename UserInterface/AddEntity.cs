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

namespace WinFromInterface
{
	public partial class AddEntity : Form
	{

		MainFrame mainFrame;

		public AddEntity(MainFrame mainFrame)
		{
			this.mainFrame = mainFrame;
			InitializeComponent();

			entityParam.RowHeadersVisible = true;
		}

		private void AddNode_Load(object sender, EventArgs e)
		{
			comboBoxTypeOfEntity.DataSource = GlobalVariables.typesOfNode;
			comboBoxTypeOfDistribution.DataSource = GlobalVariables.typesOfDistribution;
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void add_Click(object sender, EventArgs e)
		{
			try
			{
				if (nameTextBox.Text == "")
				{
					MessageBox.Show("name of entity can't be empty");
					return;
				}

				XmlNodeList xmlEntities = mainFrame.Entities.SelectNodes("Entity");

				for (int i = 0; i < xmlEntities.Count; i++)
				{
					if (xmlEntities[i].Attributes["id"]?.Value == nameTextBox.Text)
					{
						MessageBox.Show("name of entity should be unique");
						return;
					}
				}

				XmlNode node = mainFrame.Doc.CreateElement("Entity");

				XmlAttribute nodeId = mainFrame.Doc.CreateAttribute("id");
				nodeId.Value = nameTextBox.Text;
				XmlAttribute nodeType = mainFrame.Doc.CreateAttribute("type");
				nodeType.Value = (string)comboBoxTypeOfEntity.SelectedItem;

				node.Attributes.Append(nodeId);
				node.Attributes.Append(nodeType);

				if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ZGENERATOR)
				{

					XmlNode nodeNumberOfTransactions = mainFrame.Doc.CreateElement("NumberOfTransactions");
					XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
					value.Value = Convert.ToUInt32(entityParam.Rows[0].Cells[0].Value).ToString();

					nodeNumberOfTransactions.Attributes.Append(value);

					node.AppendChild(nodeNumberOfTransactions);
				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.GENERATOR)
				{
					node.AppendChild(GetDistributionNode());
				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.RECEIVER)
				{

					XmlNode number = mainFrame.Doc.CreateElement("NumberOfTransactionsToBeDeleted");
					XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
					value.Value = Convert.ToUInt32(entityParam.Rows[0].Cells[0].Value).ToString();
					number.Attributes.Append(value);

					node.AppendChild(number);

				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ONECHANNEL_FACILITY)
				{
					node.AppendChild(GetDistributionNode());
				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.MULTYCHANNEL_FACILITY)
				{

					XmlNode nodeCapasity = mainFrame.Doc.CreateElement("Capasity");
					XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
					value.Value = Convert.ToUInt32(entityParam.Rows[0].Cells[0].Value).ToString();
					nodeCapasity.Attributes.Append(value);

					node.AppendChild(nodeCapasity);
					node.AppendChild(GetDistributionNode());
				}
				else
				{
					throw new Exception("can't understand type of node");
				}

				mainFrame.Entities.AppendChild(node);

				mainFrame.UpdateEntitiesDataGradeView();

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wrong in definition, change it and try again!");
			}
		}

		private XmlNode GetDistributionNode()
		{
			XmlNode distribution = mainFrame.Doc.CreateElement("Distribution");

			XmlAttribute type = mainFrame.Doc.CreateAttribute("type");

			type.Value = (string)comboBoxTypeOfDistribution.SelectedItem;

			if ((string)comboBoxTypeOfDistribution.SelectedItem == GlobalVariables.UNIFORM)
			{
				XmlNode generatorNumber = mainFrame.Doc.CreateElement("GeneratorNumber");
				XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
				value.Value = Convert.ToUInt32(distributionParam.Rows[0].Cells[0].Value).ToString();
				generatorNumber.Attributes.Append(value);

				XmlNode lowerBound = mainFrame.Doc.CreateElement("LowerBound");
				value = mainFrame.Doc.CreateAttribute("value");
				value.Value = Convert.ToUInt32(distributionParam.Rows[0].Cells[1].Value).ToString();
				lowerBound.Attributes.Append(value);

				XmlNode upperBound = mainFrame.Doc.CreateElement("UpperBound");
				value = mainFrame.Doc.CreateAttribute("value");
				value.Value = Convert.ToUInt32(distributionParam.Rows[0].Cells[2].Value).ToString();
				upperBound.Attributes.Append(value);

				distribution.AppendChild(generatorNumber);
				distribution.AppendChild(lowerBound);
				distribution.AppendChild(upperBound);

			}
			else if ((string)comboBoxTypeOfDistribution.SelectedItem == GlobalVariables.EXPONENTIAL)
			{
				XmlNode generatorNumber = mainFrame.Doc.CreateElement("GeneratorNumber");
				XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
				value.Value = Convert.ToUInt32(distributionParam.Rows[0].Cells[0].Value).ToString();
				generatorNumber.Attributes.Append(value);

				XmlNode mathematicalExpectation = mainFrame.Doc.CreateElement("MathematicalExpectation");
				value = mainFrame.Doc.CreateAttribute("value");
				value.Value = Convert.ToUInt32(distributionParam.Rows[0].Cells[1].Value).ToString();
				mathematicalExpectation.Attributes.Append(value);

				distribution.AppendChild(generatorNumber);
				distribution.AppendChild(mathematicalExpectation);

			}
			else
			{
				throw new Exception("can't understand type of distribution");
			}

			return distribution;
		}

		private void comboBoxTypeOfNode_SelectedIndexChanged(object sender, EventArgs e)
		{
			entityParam.Rows.Clear();

			tabControl.TabPages.Remove(distributionTabPage);
			tabControl.TabPages.Remove(valuesTabPage);

			if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ZGENERATOR)
			{
				tabControl.TabPages.Remove(distributionTabPage);
				tabControl.TabPages.Add(valuesTabPage);

				entityParam.ColumnCount = 1;
				entityParam.Columns[0].Name = "Number of transactions";

			} else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.GENERATOR)
			{
				tabControl.TabPages.Add(distributionTabPage);
				comboBoxTypeOfDistribution_SelectedIndexChanged(new object(), new EventArgs());

				tabControl.TabPages.Remove(valuesTabPage);

			} else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.RECEIVER)
			{
				tabControl.TabPages.Remove(distributionTabPage);
				tabControl.TabPages.Add(valuesTabPage);

				entityParam.ColumnCount = 1;
				entityParam.Columns[0].Name = "Number of transactions to be deleted";
				
			} else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ONECHANNEL_FACILITY)
			{
				tabControl.TabPages.Add(distributionTabPage);
				comboBoxTypeOfDistribution_SelectedIndexChanged(new object(), new EventArgs());

				tabControl.TabPages.Remove(valuesTabPage);

			} else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.MULTYCHANNEL_FACILITY)
			{
				tabControl.TabPages.Add(distributionTabPage);
				comboBoxTypeOfDistribution_SelectedIndexChanged(new object(), new EventArgs());

				tabControl.TabPages.Add(valuesTabPage);

				entityParam.ColumnCount = 1;
				entityParam.Columns[0].Name = "Capasity";

			} else {
				throw new Exception("can't understand type of node");
			}

			entityParam.Rows.Add();

			distributionParam.AutoResizeColumns();
			distributionParam.AutoResizeRows();
		}

		private void comboBoxTypeOfDistribution_SelectedIndexChanged(object sender, EventArgs e)
		{
			distributionParam.Rows.Clear();

			if ((string)comboBoxTypeOfDistribution.SelectedItem == GlobalVariables.UNIFORM)
			{
				distributionParam.ColumnCount = 3;
				distributionParam.Columns[0].Name = "Generator Number";
				distributionParam.Columns[1].Name = "Lower Bound";
				distributionParam.Columns[2].Name = "Upper Bound";

			}
			else if ((string)comboBoxTypeOfDistribution.SelectedItem == GlobalVariables.EXPONENTIAL)
			{
				distributionParam.ColumnCount = 2;
				distributionParam.Columns[0].Name = "Generator Number";
				distributionParam.Columns[1].Name = "Mathematical Expectation";
			}
			else
			{
				throw new Exception("can't understand type of distribution");
			}

			distributionParam.Rows.Add();

			distributionParam.AutoResizeColumns();
			distributionParam.AutoResizeRows();
		}
	}
}
