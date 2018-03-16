using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShieldTest
{
	public partial class HelpMe : Form
	{
		public HelpMe()
		{
			InitializeComponent();
		}

		private void HelpMe_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form1 myForm = (Form1)Application.OpenForms["Form1"];
			myForm.Show();
		}

		private void HelpMe_Load(object sender, EventArgs e)
		{

		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
