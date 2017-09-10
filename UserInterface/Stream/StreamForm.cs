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
	public partial class StreamForm : Form
	{
		MainFrame mainFrame;

		XmlNode movements;

		XmlNode statistics;

		public XmlNode Movements
		{
			get
			{
				return movements;
			}

			set
			{
				movements = value;
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

		public StreamForm(MainFrame mainFrame)
		{
			this.mainFrame = mainFrame;

			InitializeComponent();

			movements = mainFrame.Doc.CreateElement("movements");
			statistics = mainFrame.Doc.CreateElement("statistics");

			fromComboBox.DataSource = mainFrame.EntitiesIdList.Clone();
			toComboBox.DataSource = mainFrame.EntitiesIdList.Clone();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			XmlNode stream = mainFrame.Doc.CreateElement("Stream");
			XmlAttribute id = mainFrame.Doc.CreateAttribute("id");

			if (streamIdTextBox.Text == "")
			{
				MessageBox.Show("Stream should have id");
				return;
			}
			if (mainFrame.StreamIdList.Contains(streamIdTextBox.Text))
			{
				MessageBox.Show("Stream id should uniqie");
				return;
			}

			id.Value = streamIdTextBox.Text;
			stream.Attributes.Append(id);

			stream.AppendChild(movements);
			stream.AppendChild(statistics);

			mainFrame.Streams.AppendChild(stream);

			mainFrame.UpdateStreamList();

			this.Close();
		}

		private void addMovementButton_Click(object sender, EventArgs e)
		{
			
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

		public void UpdateMovementsDataGridView()
		{
			movementsDataGridView.Rows.Clear();

			XmlNodeList movementsList = movements.SelectNodes("movement");
			
			for (int i = 0; i < movementsList.Count; i++)
			{
				string[] row = new string[3];

				row[0] = movementsList[i].Attributes["from"]?.Value;
				row[1] = movementsList[i].Attributes["to"]?.Value;
				row[2] = movementsList[i].Attributes["value"]?.Value;

				movementsDataGridView.Rows.Add(row);
			}
		}
	}
}
