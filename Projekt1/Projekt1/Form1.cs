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

namespace Projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
            var privateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
            var publicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny

            //string publicKeyString = GetKeyString(publicKey);
            //string privateKeyString = GetKeyString(privateKey);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "Wszystkie pliki|*";
                upload.Title = "Wybierz plik";
                if (upload.ShowDialog() != DialogResult.OK) return;
                string filePath = upload.FileName;
                string fileName = upload.SafeFileName;
                string filePathName = upload.FileName.Replace(upload.SafeFileName, "");
                textBox3.Text = filePath;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string sciezka = textBox3.Text;
            textBox1.Text = sciezka;
            MessageBox.Show("Ścieżka to: " + sciezka);
        }

        //cokolwiek drugie żeby sprawdzić czy zmiany będą poprawnie przesyłane


    }
}
