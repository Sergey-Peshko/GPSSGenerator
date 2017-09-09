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

namespace WinFromInterface
{
	public partial class AddStatistic : Form
	{
		public AddStatistic(MainFrame mainFrame)
		{
			InitializeComponent();
			comboBoxTypeOfStatistic.DataSource = GlobalVariables.typesOfStatistics;
		}

		private void AddStatistic_Load(object sender, EventArgs e)
		{
			comboBoxTypeOfStatistic.DataSource = GlobalVariables.typesOfStatistics;
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
