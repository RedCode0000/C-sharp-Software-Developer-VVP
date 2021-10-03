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
		String operation = "";
		bool enter_value = false;
		String firstnum, secondnum;
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

			if (b.Text == ",")
			{
				if (!txtDisplay.Text.Contains(","))
					txtDisplay.Text = txtDisplay.Text + b.Text;

			}
			else
			{
				txtDisplay.Text = txtDisplay.Text + b.Text;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			treeView1.Visible = false;
		}

		private void operator_Click(object sender, EventArgs e)
		{
			Button b = (Button)sender;

			if (result != 0)
			{
				btnEquals.PerformClick();
				enter_value = true;
				operation = b.Text;
				lblShowOps.Text = result + " " + operation;
			}
			else
			{
				operation = b.Text;
				result = Double.Parse(txtDisplay.Text);
				enter_value = true;
				lblShowOps.Text = result + " " + operation;
			}

			firstnum = lblShowOps.Text;
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{

			secondnum = txtDisplay.Text;
			lblShowOps.Text = "";
			switch (operation)
			{
				case "+":
					txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "-":
					txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "X":
					txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
					break;
				case "/":
					txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
					break;
                case "%":
					txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
					break;
				default:
					break;
			}
			result = Double.Parse(txtDisplay.Text);
			operation = "";
			//===========================================


			btnClearHistory.Visible = true;
			rtbDisplayHistory.AppendText(firstnum + "    " + secondnum + "  =  " + "\n");
			rtbDisplayHistory.AppendText("\n\t" + txtDisplay.Text + "\n\n");
			lblHistoryDisplay.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = "0";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			txtDisplay.Text = "0";
			result = 0;
		}

		private void btnClearHistory_Click(object sender, EventArgs e)
		{
			rtbDisplayHistory.Clear();
			if (lblHistoryDisplay.Text =="")
			{
				lblHistoryDisplay.Text = "Geen geschiedenis op dit moment";
			}
			btnClearHistory.Visible = false;
			rtbDisplayHistory.ScrollBars = 0;
		}

		private void rtbDisplayHistory_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblHistoryDisplay_Click(object sender, EventArgs e)
		{

		}

        private void label1_Click(object sender, EventArgs e)
        {
			treeView1.Visible = true;
		}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
			if(e.Node.Name =="Node2")
            {
				lblTitle.Text = "Standaard";
				treeView1.Visible = false;
            }
			if (e.Node.Name == "Node4")
			{
				lblTitle.Text = "Wetenschappelijk";
				treeView1.Visible = false;
			}
			if (e.Node.Name == "Node6")
			{
				lblTitle.Text = "Programmer";
				treeView1.Visible = false;
			}
		}

        private void Percentage_Click(object sender, EventArgs e)
		{

			Button b = (Button)sender;

			if (result != 0)
			{
				btnEquals.PerformClick();
				enter_value = true;
				operation = b.Text;
				lblShowOps.Text = result + " " + operation;
			}
			else
			{
				operation = b.Text;
				result = Double.Parse(txtDisplay.Text);
				enter_value = true;
				lblShowOps.Text = result + " " + operation;
			}

			firstnum = lblShowOps.Text;

			Double a;
			a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
			txtDisplay.Text = System.Convert.ToString(a);

			
		}

		private void Plusminus_Click(object sender, EventArgs e)
        {
			result = double.Parse(txtDisplay.Text);
			result = result * -1;
			txtDisplay.Text = result.ToString();
		}

        private void button19_Click(object sender, EventArgs e)
        {

			Button b = (Button)sender;

			if (result != 0)
			{
				btnEquals.PerformClick();
				enter_value = true;
				operation = b.Text;
				lblShowOps.Text = operation + " " + result;
			}
			else
			{
				operation = b.Text;
				result = Double.Parse(txtDisplay.Text);
				enter_value = true;
				lblShowOps.Text = operation + " " + result;
			}

			firstnum = lblShowOps.Text;

			Double a;

			a = Convert.ToDouble(1.0  / Convert.ToDouble(txtDisplay.Text));
			txtDisplay.Text = System.Convert.ToString(a);

			
		}

        private void button7_Click(object sender, EventArgs e)
		{

			Button b = (Button)sender;

			if (result != 0)
			{
				btnEquals.PerformClick();
				enter_value = true;
				operation = b.Text;
				lblShowOps.Text = operation + " " + result;

			}
			else
			{
				operation = b.Text;
				result = Double.Parse(txtDisplay.Text);
				enter_value = true;
				lblShowOps.Text = operation + " " + result;
			}

			firstnum = lblShowOps.Text;

			double sq = Double.Parse(txtDisplay.Text);
			lblShowOps.Text = System.Convert.ToString("√" + (txtDisplay.Text));
			sq = Math.Sqrt(sq);
			txtDisplay.Text = System.Convert.ToString(sq);

			
		}

        private void button13_Click(object sender, EventArgs e)
        {
			Button b = (Button)sender;

			if (result != 0)
			{
				btnEquals.PerformClick();
				enter_value = true;
				operation = b.Text;
				lblShowOps.Text = result + " " + operation;
			}
			else
			{
				operation = b.Text;
				result = Double.Parse(txtDisplay.Text);
				enter_value = true;
				lblShowOps.Text = result + " " + operation;
			}

			firstnum = lblShowOps.Text;

			Double a;

			a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
			txtDisplay.Text = System.Convert.ToString(a);

			
		}

        private void btnBackSpace_Click(object sender, EventArgs e)
		{
			if (txtDisplay.Text.Length > 0)
			{
				txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
			}

			if (txtDisplay.Text == "")
			{
				txtDisplay.Text = "0";
			}
		}
	}
}
