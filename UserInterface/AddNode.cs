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
	public partial class AddNode : Form
	{
		public AddNode()
		{
			InitializeComponent();
		}

		private void AddNode_Load(object sender, EventArgs e)
		{
			comboBoxTypeOfNode.DataSource = GlobalVariables.typesOfNode;
			comboBoxTypeOfDistribution.DataSource = GlobalVariables.typesOfDistribution;
		}
	}
}
