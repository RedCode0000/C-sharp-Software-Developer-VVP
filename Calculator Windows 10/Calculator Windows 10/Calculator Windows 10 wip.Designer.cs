
namespace Calculator_Windows_10
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Rekenmachine");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Standaard");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Wetenschappelijk");
            this.Percentage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Plusminus = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHistoryDisplay = new System.Windows.Forms.Label();
            this.lblShowOps = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Percentage
            // 
            this.Percentage.AccessibleName = "%";
            this.Percentage.BackColor = System.Drawing.Color.Silver;
            this.Percentage.FlatAppearance.BorderSize = 0;
            this.Percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.Location = new System.Drawing.Point(13, 198);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(90, 68);
            this.Percentage.TabIndex = 0;
            this.Percentage.Text = "%\r\n";
            this.Percentage.UseVisualStyleBackColor = false;
            this.Percentage.Click += new System.EventHandler(this.Percentage_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 68);
            this.button3.TabIndex = 0;
            this.button3.Text = "7";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(13, 420);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 68);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(13, 494);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 68);
            this.button5.TabIndex = 0;
            this.button5.Text = "1";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.numbers_Only);
            // 
            // Plusminus
            // 
            this.Plusminus.BackColor = System.Drawing.Color.Gainsboro;
            this.Plusminus.FlatAppearance.BorderSize = 0;
            this.Plusminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plusminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plusminus.Location = new System.Drawing.Point(13, 568);
            this.Plusminus.Name = "Plusminus";
            this.Plusminus.Size = new System.Drawing.Size(90, 68);
            this.Plusminus.TabIndex = 0;
            this.Plusminus.Text = "±";
            this.Plusminus.UseVisualStyleBackColor = false;
            this.Plusminus.Click += new System.EventHandler(this.Plusminus_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(109, 198);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 68);
            this.button7.TabIndex = 0;
            this.button7.Text = "√\r\n";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(109, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 68);
            this.button8.TabIndex = 0;
            this.button8.Text = "C";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(109, 346);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(90, 68);
            this.button9.TabIndex = 0;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(109, 420);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(90, 68);
            this.button10.TabIndex = 0;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(109, 494);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(90, 68);
            this.button11.TabIndex = 0;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gainsboro;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(109, 568);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 68);
            this.button12.TabIndex = 0;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(205, 198);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(90, 68);
            this.button13.TabIndex = 0;
            this.button13.Text = "x^2";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.Location = new System.Drawing.Point(205, 272);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(90, 68);
            this.btnBackSpace.TabIndex = 0;
            this.btnBackSpace.Text = "⌫";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gainsboro;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(205, 346);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(90, 68);
            this.button15.TabIndex = 0;
            this.button15.Text = "9";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gainsboro;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(205, 420);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(90, 68);
            this.button16.TabIndex = 0;
            this.button16.Text = "6";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gainsboro;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(205, 494);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(90, 68);
            this.button17.TabIndex = 0;
            this.button17.Text = "3";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gainsboro;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(205, 568);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(90, 68);
            this.button18.TabIndex = 0;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.numbers_Only);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Silver;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(301, 198);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(90, 68);
            this.button19.TabIndex = 0;
            this.button19.Text = "1/x\r\n";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Gainsboro;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(301, 272);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(90, 68);
            this.button20.TabIndex = 0;
            this.button20.Text = "/";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.operator_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.Gainsboro;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(301, 346);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(90, 68);
            this.button21.TabIndex = 0;
            this.button21.Text = "X";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.operator_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.Gainsboro;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(301, 420);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(90, 68);
            this.button22.TabIndex = 0;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.operator_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.Gainsboro;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(301, 494);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(90, 68);
            this.button23.TabIndex = 0;
            this.button23.Text = "+";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(301, 568);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(90, 68);
            this.btnEquals.TabIndex = 0;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 68);
            this.button2.TabIndex = 0;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbDisplayHistory
            // 
            this.rtbDisplayHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDisplayHistory.Location = new System.Drawing.Point(584, 160);
            this.rtbDisplayHistory.Name = "rtbDisplayHistory";
            this.rtbDisplayHistory.Size = new System.Drawing.Size(177, 443);
            this.rtbDisplayHistory.TabIndex = 1;
            this.rtbDisplayHistory.Text = "";
            this.rtbDisplayHistory.TextChanged += new System.EventHandler(this.rtbDisplayHistory_TextChanged);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(719, 609);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(42, 36);
            this.btnClearHistory.TabIndex = 2;
            this.btnClearHistory.Text = "🗑";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "☰";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(58, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Standaard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Geheugen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(462, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Geschiedenis";
            // 
            // lblHistoryDisplay
            // 
            this.lblHistoryDisplay.AutoSize = true;
            this.lblHistoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistoryDisplay.Location = new System.Drawing.Point(462, 87);
            this.lblHistoryDisplay.Name = "lblHistoryDisplay";
            this.lblHistoryDisplay.Size = new System.Drawing.Size(369, 25);
            this.lblHistoryDisplay.TabIndex = 3;
            this.lblHistoryDisplay.Text = "Geen geschiedenis op dit moment";
            this.lblHistoryDisplay.Click += new System.EventHandler(this.lblHistoryDisplay_Click);
            // 
            // lblShowOps
            // 
            this.lblShowOps.AutoSize = true;
            this.lblShowOps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOps.Location = new System.Drawing.Point(280, 87);
            this.lblShowOps.Name = "lblShowOps";
            this.lblShowOps.Size = new System.Drawing.Size(0, 25);
            this.lblShowOps.TabIndex = 3;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(13, 133);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(378, 59);
            this.txtDisplay.TabIndex = 4;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_txtChanged);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Location = new System.Drawing.Point(2, 49);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Rekenmachine";
            treeNode2.Name = "Node1";
            treeNode2.Text = "";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Standaard";
            treeNode4.Name = "Node3";
            treeNode4.Text = "";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Wetenschappelijk";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(293, 476);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 651);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblHistoryDisplay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblShowOps);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.rtbDisplayHistory);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.Plusminus);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Percentage);
            this.MaximumSize = new System.Drawing.Size(789, 690);
            this.MinimumSize = new System.Drawing.Size(420, 690);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Percentage;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button Plusminus;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button btnBackSpace;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button btnEquals;
		private System.Windows.Forms.RichTextBox rtbDisplayHistory;
		private System.Windows.Forms.Button btnClearHistory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblHistoryDisplay;
		private System.Windows.Forms.Label lblShowOps;
		private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TreeView treeView1;
    }
}

