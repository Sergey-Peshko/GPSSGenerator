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
		public MainFrame()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			AddNode addNode = new AddNode();
			addNode.Show();
		}

		private void buttonAddStream_Click(object sender, EventArgs e)
		{
			StreamDescription s = new StreamDescription();
			s.Show();
		}
	}
}
