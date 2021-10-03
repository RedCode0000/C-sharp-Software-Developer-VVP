using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Windows_10
{
	public partial class Form1 : Form
	{
		Double result = 0;
		String operation =""
			bool enter_value = false;
		char iOperation;
		public Form1()
		{
			InitializeComponent();
		}

		private void txtDisplay_txtChanged(object sender, EventArgs e)
		{
		
		}

		private void numbers_Only(object sender, EventArgs e)
		{
			Button b = (Button)sender;

			if ((txtDisplay.Text == "0") || (enter_value))
					txtDisplay.Text = "";
			enter_value = false;

			if (b.Text == ".")
			{
				if (!txtDisplay.Text.Contains("."))
					txtDisplay.Text = txtDisplay.Text + b.Text;

			}
			else
			{
				txtDisplay.Text = txtDisplay.Text + b.Text;
			}
		{
	}
}
