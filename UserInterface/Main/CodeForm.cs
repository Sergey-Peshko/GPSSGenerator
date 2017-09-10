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
	public partial class CodeForm : Form
	{
		public CodeForm(List<string> code)
		{
			InitializeComponent();

			for (int i = 0; i < code.Count; i++)
			{
				codeTextBox.AppendText(code[i] + '\n');
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
