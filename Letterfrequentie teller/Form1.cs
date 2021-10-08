using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Letterfrequentie_teller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath); 
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btn_createLetterList_Click(object sender, EventArgs e)
        {
            String AllLetters = textBox1.Text;
            string[] lettersArray = Regex.Split(AllLetters, string.Empty);
            

            foreach (string letter in lettersArray)
            {
                Console.WriteLine(letter);
                if (!listBox1.Items.Contains(letter))
                {
                    listBox1.Items.Add(letter);
                }
            }
        }

        private void btn_sortLetterList_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void btn_countLetters_Click(object sender, EventArgs e)
        {
            String AllLetters = textBox1.Text;
            string[] lettersArray = Regex.Split(AllLetters, string.Empty);

            List<LetterCounter> letterCounters = new List<LetterCounter>();

            foreach (string w in lettersArray)
            {
                Console.WriteLine(w);
                LetterCounter foundLetter = letterCounters.Find( x => x.letter == w);
                if (foundLetter == null)
                {
                    letterCounters.Add(new LetterCounter(w,1));
                }
                else
                {
                    foundLetter.frequency++;
                }
            }

            listView1.Columns.Add("Frequency", 70);
            listView1.Columns.Add("Letter", 70);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Descending;

            foreach (LetterCounter letter in letterCounters)
            {
                string[] rowItem = new string[] {letter.frequency.ToString("D5"), letter.letter};
                listView1.Items.Add( new ListViewItem(rowItem));
            }
        }
    }
}
