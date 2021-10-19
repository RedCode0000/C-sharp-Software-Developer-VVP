using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace Encryptie_en_Decryptie_document
{
    public partial class Form1 : Form
    {

        string key;
        public Form1()
        {
            InitializeComponent();
            key = generateKey();
        }

        private string generateKey()
        {
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            txtLocalEncFile.Text = open.FileName;

            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

            txtNewEncFile.Text = save.FileName;

            encrypt(txtLocalEncFile.Text, txtNewEncFile.Text, key);
        }

        private void encrypt(string input, string output, string strHash)
        {
            FileStream inStream, outStream;
            CryptoStream Crystream;
            TripleDESCryptoServiceProvider TDC = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] byteHash, byteTexto;

            inStream = new FileStream(input, FileMode.Open, FileAccess.Read);
            outStream = new FileStream(output, FileMode.OpenOrCreate, FileAccess.Write);

            byteHash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strHash));
            byteTexto = File.ReadAllBytes(input);

            md5.Clear();

            TDC.Key = byteHash;
            TDC.Mode = CipherMode.ECB;

            Crystream = new CryptoStream(outStream, TDC.CreateEncryptor(), CryptoStreamMode.Write);

            int bytesRead;
            long length, position = 0;
            length = inStream.Length;

            while(position < length)
            {
                bytesRead = inStream.Read(byteTexto, 0, byteTexto.Length);
                position += bytesRead;

                Crystream.Write(byteTexto, 0, bytesRead);
            }

            inStream.Close();
            outStream.Close();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            txtLocalDecFile.Text = open.FileName;

            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

            txtNewDecFile.Text = save.FileName;

            decrypt(txtLocalDecFile.Text, txtNewDecFile.Text, key);
        }

        private void decrypt(string input, string output, string strHash)
        {
            FileStream inStream, outStream;
            CryptoStream Crystream;
            TripleDESCryptoServiceProvider TDC = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] byteHash, byteTexto;

            inStream = new FileStream(input, FileMode.Open, FileAccess.Read);
            outStream = new FileStream(output, FileMode.OpenOrCreate, FileAccess.Write);

            byteHash = md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strHash));
            byteTexto = File.ReadAllBytes(input);

            md5.Clear();

            TDC.Key = byteHash;
            TDC.Mode = CipherMode.ECB;

            Crystream = new CryptoStream(outStream, TDC.CreateDecryptor(), CryptoStreamMode.Write);

            int bytesRead;
            long length, position = 0;
            length = inStream.Length;

            while (position < length)
            {
                bytesRead = inStream.Read(byteTexto, 0, byteTexto.Length);
                position += bytesRead;

                Crystream.Write(byteTexto, 0, bytesRead);
            }

            inStream.Close();
            outStream.Close();
        }
    }
}

