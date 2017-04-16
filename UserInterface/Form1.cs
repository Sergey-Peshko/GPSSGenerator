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

namespace UserInterface
{
	public partial class MainFrame : Form
	{

		private GlobalModel globalModel; 
		public MainFrame()
		{
			globalModel = new GlobalModel();

			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBoxTypeOfNet.DataSource = GlobalVariables.typesOfNet;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			AddNode addNode = new AddNode();
			addNode.Show();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			groupBoxCommonParam.Enabled = true;
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			NetSettings netSettings = new NetSettings();
			netSettings.NumberOfTransactions = (int)numericNumberOfTransactions.Value;
			netSettings.TypeOfNet = (string)comboBoxTypeOfNet.SelectedItem;
		}

		private void buttonAddStream_Click(object sender, EventArgs e)
		{
			StreamDescription s = new StreamDescription();
			s.Show();
		}
	}
}
