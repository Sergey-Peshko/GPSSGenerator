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
	public partial class EntityForm : Form
	{

		MainFrame mainFrame;

		Mode mode;

		XmlNode node;

		public EntityForm(MainFrame mainFrame)
		{
			this.mainFrame = mainFrame;
			this.mode = Mode.Add;
			InitializeComponent();

			comboBoxTypeOfEntity.DataSource = GlobalVariables.typesOfNode;
		}

		public EntityForm(MainFrame mainFrame, XmlNode entity)
		{
			this.mainFrame = mainFrame;
			this.mode = Mode.Edit;
			this.node = entity;
			InitializeComponent();

			nameTextBox.Enabled = false;

			comboBoxTypeOfEntity.DataSource = GlobalVariables.typesOfNode;

			nameTextBox.Text = entity.Attributes["id"]?.Value;

			comboBoxTypeOfEntity.SelectedItem = entity.Attributes["type"]?.Value;

			if (entity.Attributes["type"]?.Value == GlobalVariables.ZGENERATOR)
			{
				numberOfTransactionsNumericUpDown.Value =
					Convert.ToDecimal(
						entity.SelectSingleNode("NumberOfTransactions").
						Attributes["value"]?.Value);
			}
			else if (entity.Attributes["type"]?.Value == GlobalVariables.GENERATOR)
			{
				FillOutDistribution(entity.SelectSingleNode("Distribution"));
			}
			else if (entity.Attributes["type"]?.Value == GlobalVariables.RECEIVER)
			{
				numberOfTransactionsToBeDeletedNumericUpDown.Value = 
					Convert.ToDecimal(
						entity.SelectSingleNode("NumberOfTransactionsToBeDeleted").
						Attributes["value"]?.Value);
			}
			else if (entity.Attributes["type"]?.Value == GlobalVariables.ONECHANNEL_FACILITY)
			{
				FillOutDistribution(entity.SelectSingleNode("Distribution"));
			}
			else if (entity.Attributes["type"]?.Value == GlobalVariables.MULTYCHANNEL_FACILITY)
			{
				capacityNumericUpDown.Value = 
					Convert.ToDecimal(
						entity.SelectSingleNode("Capacity").Attributes["value"]?.Value);
				FillOutDistribution(entity.SelectSingleNode("Distribution"));
			}
			else
			{
				throw new Exception("can't understand type of node");
			}
		}

		private void FillOutDistribution(XmlNode distribution)
		{
			if(distribution.Attributes["type"]?.Value == GlobalVariables.UNIFORM)
			{
				comboBoxTypeOfEntity.SelectedItem = GlobalVariables.UNIFORM;
				distributionParam.Rows[0].Cells[0].Value = distribution.SelectSingleNode("GeneratorNumber").Attributes["value"]?.Value;
				distributionParam.Rows[0].Cells[1].Value = distribution.SelectSingleNode("LowerBound").Attributes["value"]?.Value;
				distributionParam.Rows[0].Cells[2].Value = distribution.SelectSingleNode("UpperBound").Attributes["value"]?.Value;
			}
			else if (distribution.Attributes["type"]?.Value == GlobalVariables.EXPONENTIAL)
			{
				comboBoxTypeOfEntity.SelectedItem = GlobalVariables.EXPONENTIAL;
				distributionParam.Rows[0].Cells[0].Value = distribution.SelectSingleNode("GeneratorNumber").Attributes["value"]?.Value;
				distributionParam.Rows[0].Cells[1].Value = distribution.SelectSingleNode("MathematicalExpectation").Attributes["value"]?.Value;
			}
			else
			{
				throw new Exception("can't understand type of distribution");
			}
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private XmlNode GetDistributionNode()
		{
			XmlNode distribution = mainFrame.Doc.CreateElement("Distribution");

			XmlAttribute type = mainFrame.Doc.CreateAttribute("type");
			type.Value = (string)comboBoxTypeOfDistribution.SelectedItem;

			distribution.Attributes.Append(type);

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

		private void EnableTab(TabPage page, bool enable)
		{
			foreach (Control ctl in page.Controls) ctl.Enabled = enable;
		}
		private void VisibleTab(TabPage page, bool visible)
		{
			foreach (Control ctl in page.Controls) ctl.Visible = visible;
		}

		private void comboBoxTypeOfNode_SelectedIndexChanged(object sender, EventArgs e)
		{
			tabControl.TabPages.Clear();

			if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ZGENERATOR)
			{
				tabControl.TabPages.Add(numberOfTransactionsTabPage);
			}
			else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.GENERATOR)
			{
				tabControl.TabPages.Add(distributionTabPage);
				comboBoxTypeOfDistribution.DataSource = GlobalVariables.typesOfDistribution;
			}
			else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.RECEIVER)
			{
				tabControl.TabPages.Add(numberOfTransactionsToBeDeletedTabPage);
			}
			else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ONECHANNEL_FACILITY)
			{

				tabControl.TabPages.Add(distributionTabPage);
				comboBoxTypeOfDistribution.DataSource = GlobalVariables.typesOfDistribution;
			}
			else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.MULTYCHANNEL_FACILITY)
			{
				tabControl.TabPages.Add(distributionTabPage);
				comboBoxTypeOfDistribution.DataSource = GlobalVariables.typesOfDistribution;
				tabControl.TabPages.Add(capasityTabPage);
			}
			else
			{
				throw new Exception("can't understand type of node");
			}
		}

		private void comboBoxTypeOfDistribution_SelectedIndexChanged(object sender, EventArgs e)
		{
			distributionParam.Rows.Clear();

			if ((string)comboBoxTypeOfDistribution.SelectedValue == GlobalVariables.UNIFORM)
			{
				distributionParam.ColumnCount = 3;
				distributionParam.Columns[0].Name = "Generator Number";
				distributionParam.Columns[1].Name = "Lower Bound";
				distributionParam.Columns[2].Name = "Upper Bound";

			}
			else if ((string)comboBoxTypeOfDistribution.SelectedValue == GlobalVariables.EXPONENTIAL)
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

		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{

				if (nameTextBox.Text == "")
				{
					MessageBox.Show("name of entity can't be empty");
					return;
				}

				if (mode == Mode.Add)
				{

					XmlNodeList xmlEntities = mainFrame.Entities.SelectNodes("Entity");

					for (int i = 0; i < xmlEntities.Count; i++)
					{
						if (xmlEntities[i].Attributes["id"]?.Value == nameTextBox.Text)
						{
							MessageBox.Show("name of entity should be unique");
							return;
						}
					}
				}

				XmlNode newNode = mainFrame.Doc.CreateElement("Entity");

				XmlAttribute nodeId = mainFrame.Doc.CreateAttribute("id");
				nodeId.Value = nameTextBox.Text;
				XmlAttribute nodeType = mainFrame.Doc.CreateAttribute("type");
				nodeType.Value = (string)comboBoxTypeOfEntity.SelectedItem;

				newNode.Attributes.Append(nodeId);
				newNode.Attributes.Append(nodeType);

				if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ZGENERATOR)
				{

					XmlNode nodeNumberOfTransactions = mainFrame.Doc.CreateElement("NumberOfTransactions");
					XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
					value.Value = numberOfTransactionsNumericUpDown.Value.ToString();

					nodeNumberOfTransactions.Attributes.Append(value);

					newNode.AppendChild(nodeNumberOfTransactions);
				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.GENERATOR)
				{
					newNode.AppendChild(GetDistributionNode());
				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.RECEIVER)
				{

					XmlNode number = mainFrame.Doc.CreateElement("NumberOfTransactionsToBeDeleted");
					XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
					value.Value = numberOfTransactionsToBeDeletedNumericUpDown.Value.ToString();
					number.Attributes.Append(value);

					newNode.AppendChild(number);

				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.ONECHANNEL_FACILITY)
				{
					newNode.AppendChild(GetDistributionNode());
				}
				else if ((string)comboBoxTypeOfEntity.SelectedItem == GlobalVariables.MULTYCHANNEL_FACILITY)
				{

					XmlNode nodeCapasity = mainFrame.Doc.CreateElement("Capasity");
					XmlAttribute value = mainFrame.Doc.CreateAttribute("value");
					value.Value = capacityNumericUpDown.Value.ToString();
					nodeCapasity.Attributes.Append(value);

					newNode.AppendChild(nodeCapasity);
					newNode.AppendChild(GetDistributionNode());
				}
				else
				{
					throw new Exception("can't understand type of node");
				}
				if (mode == Mode.Add)
				{
					mainFrame.Entities.AppendChild(newNode);
				}
				else
				{
					mainFrame.Entities.ReplaceChild(newNode, node);
				}

				mainFrame.UpdateEntitiesDataGradeView();

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something wrong in definition, change it and try again!");
			}
		}
	}
}
