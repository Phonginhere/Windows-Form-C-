using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class FormLost : Form
	{
		public FormLost()
		{
			InitializeComponent();
			label2.Visible = false;
			textBox2.Visible = false;
			button2.Visible = false;
			toolStripStatusLabel1.Visible = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form1 f1 = new Form1();
			f1.Show();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
