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

namespace UserInterface
{
	public partial class AddNode : Form
	{

		MainFrame mainFrame;

		public AddNode(MainFrame mainFrame)
		{
			this.mainFrame = mainFrame;
			InitializeComponent();

			nodeParam.RowHeadersVisible = true;
		}

		private void AddNode_Load(object sender, EventArgs e)
		{
			comboBoxTypeOfNode.DataSource = GlobalVariables.typesOfNode;
			comboBoxTypeOfDistribution.DataSource = GlobalVariables.typesOfDistribution;
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void add_Click(object sender, EventArgs e)
		{
			if(nameTextBox.Text == "")
			{
				MessageBox.Show("name of entity can't be empty");
				return;
			}

			XmlNodeList xmlEntities = mainFrame.Entities.SelectNodes("Entity");

			for (int i = 0; i < xmlEntities.Count; i++) 
			{
				if(xmlEntities[i].Attributes["id"]?.Value == nameTextBox.Text)
				{
					MessageBox.Show("name of entity should be unique");
					return;
				}
			}

			XmlNode node = mainFrame.Doc.CreateElement("Entity");

			XmlAttribute nodeId = mainFrame.Doc.CreateAttribute("id");
			nodeId.Value = nameTextBox.Text;
			XmlAttribute nodeType = mainFrame.Doc.CreateAttribute("type");
			nodeType.Value = (string)comboBoxTypeOfNode.SelectedItem;

			node.Attributes.Append(nodeId);
			node.Attributes.Append(nodeType);

			mainFrame.Entities.AppendChild(node);

			mainFrame.UpdateEntitiesDataGradeView();

			this.Close();
		}

		private void comboBoxTypeOfNode_SelectedIndexChanged(object sender, EventArgs e)
		{
			nodeParam.Rows.Clear();

			if ((string)comboBoxTypeOfNode.SelectedItem == GlobalVariables.ZGENERATOR)
			{
				distributionGroupBox.Visible = false;
				nodeParamGroupBox.Visible = true;

				nodeParam.ColumnCount = 1;
				nodeParam.Columns[0].Name = "Number of transactions";

			} else if ((string)comboBoxTypeOfNode.SelectedItem == GlobalVariables.GENERATOR)
			{
				distributionGroupBox.Visible = true;
				nodeParamGroupBox.Visible = false;

				nodeParam.ColumnCount = 1;
				nodeParam.Columns[0].Name = "Capasity";

			} else if ((string)comboBoxTypeOfNode.SelectedItem == GlobalVariables.RECEIVER)
			{
				distributionGroupBox.Visible = false;
				nodeParamGroupBox.Visible = true;

				nodeParam.ColumnCount = 1;
				nodeParam.Columns[0].Name = "Number of transactions to be deleted";
				
			} else if ((string)comboBoxTypeOfNode.SelectedItem == GlobalVariables.ONECHANNEL_FACILITY)
			{
				distributionGroupBox.Visible = true;
				nodeParamGroupBox.Visible = false;

			} else if ((string)comboBoxTypeOfNode.SelectedItem == GlobalVariables.MULTYCHANNEL_FACILITY)
			{
				distributionGroupBox.Visible = true;
				nodeParamGroupBox.Visible = true;

			} else {
				throw new Exception("can't understand type of node");
			}

			nodeParam.Rows.Add();

			distributionParam.AutoResizeColumns();
			distributionParam.AutoResizeRows();
		}

		private void comboBoxTypeOfDistribution_SelectedIndexChanged(object sender, EventArgs e)
		{
			distributionParam.Rows.Clear();

			if ((string)comboBoxTypeOfDistribution.SelectedItem == GlobalVariables.UNIFORM)
			{
				distributionParam.ColumnCount = 2;
				distributionParam.Columns[0].Name = "Generator Number";
				distributionParam.Columns[0].Name = "Lower Bound";
				distributionParam.Columns[0].Name = "Upper Bound";

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
