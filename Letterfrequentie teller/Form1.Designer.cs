
namespace Letterfrequentie_teller
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ChooseFile = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_createLetterList = new System.Windows.Forms.Button();
            this.btn_sortLetterList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_countLetters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Load a Text File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Split the File into letters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. Count the frequency of Each Letter";
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.Location = new System.Drawing.Point(12, 38);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(80, 36);
            this.btn_ChooseFile.TabIndex = 3;
            this.btn_ChooseFile.Text = "Choose a File";
            this.btn_ChooseFile.UseVisualStyleBackColor = true;
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(98, 38);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(80, 36);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_createLetterList
            // 
            this.btn_createLetterList.Location = new System.Drawing.Point(314, 38);
            this.btn_createLetterList.Name = "btn_createLetterList";
            this.btn_createLetterList.Size = new System.Drawing.Size(80, 36);
            this.btn_createLetterList.TabIndex = 3;
            this.btn_createLetterList.Text = "Create Letter List";
            this.btn_createLetterList.UseVisualStyleBackColor = true;
            this.btn_createLetterList.Click += new System.EventHandler(this.btn_createLetterList_Click);
            // 
            // btn_sortLetterList
            // 
            this.btn_sortLetterList.Location = new System.Drawing.Point(400, 38);
            this.btn_sortLetterList.Name = "btn_sortLetterList";
            this.btn_sortLetterList.Size = new System.Drawing.Size(80, 36);
            this.btn_sortLetterList.TabIndex = 4;
            this.btn_sortLetterList.Text = "Sort Letters";
            this.btn_sortLetterList.UseVisualStyleBackColor = true;
            this.btn_sortLetterList.Click += new System.EventHandler(this.btn_sortLetterList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 521);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 524);
            this.listBox1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(641, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(256, 524);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_countLetters
            // 
            this.btn_countLetters.Location = new System.Drawing.Point(641, 38);
            this.btn_countLetters.Name = "btn_countLetters";
            this.btn_countLetters.Size = new System.Drawing.Size(80, 36);
            this.btn_countLetters.TabIndex = 8;
            this.btn_countLetters.Text = "Count";
            this.btn_countLetters.UseVisualStyleBackColor = true;
            this.btn_countLetters.Click += new System.EventHandler(this.btn_countLetters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 605);
            this.Controls.Add(this.btn_countLetters);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sortLetterList);
            this.Controls.Add(this.btn_createLetterList);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_ChooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ChooseFile;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_createLetterList;
        private System.Windows.Forms.Button btn_sortLetterList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_countLetters;
    }
}

