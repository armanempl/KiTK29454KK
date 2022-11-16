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

        }

        private void PubFileSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "Pliki tekstowe|*.txt";
                upload.Filter = "Wszystkie pliki|*";
                upload.Title = "Wybierz plik do zaszyfrowania";
                if (upload.ShowDialog() != DialogResult.OK) return;
                string filePath = upload.FileName;
                string fileName = upload.SafeFileName;
                string filePathName = upload.FileName.Replace(upload.SafeFileName, "");
                PubFilePath.Text = filePath;
            }
        }
        private void PrivFileSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = "Pliki tekstowe|*.txt";
                upload.Filter = "Wszystkie pliki|*";
                upload.Title = "Wybierz plik do zaszyfrowania";
                if (upload.ShowDialog() != DialogResult.OK) return;
                string filePath = upload.FileName;
                string fileName = upload.SafeFileName;
                string filePathName = upload.FileName.Replace(upload.SafeFileName, "");
                PrivFilePath.Text = filePath;
            }
        }

        private void button2_Click(object sender, EventArgs e) //szyfruj
        {
            string sciezka = PubFilePath.Text;
            string publicKey = PubKeyPath.Text;
            if (sciezka == "")
            {
                MessageBox.Show("Nie wybrano pliku, najpierw wskaż ścieżkę do pliku do zaszyfrowania");
            }
            else if (publicKey == "")
            {
                MessageBox.Show("Nie wybrano pliku klucza publicznego, spróbuj ponownie");
            } else
            {
                string publicKeyText = System.IO.File.ReadAllText(publicKey);
                string fileText = System.IO.File.ReadAllText(sciezka);
                string encryptedText = Encrypt(fileText, publicKeyText);
                //MessageBox.Show(encryptedText);

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.Filter = "Wszystkie pliki|*|Plik txt|*.txt";
                //saveFileDialog1.Filter = "Wszystkie pliki|*";
                saveFileDialog1.Title = "Wybierz lokalizację zapisu zaszyfrowanego pliku";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                    {
                        AddText(fs, encryptedText);
                    }
                }
                MessageBox.Show("Zaszyfrowano plik \n Został zapisany w lokalizacji: \n " + saveFileDialog1.FileName);
                System.Diagnostics.Process.Start("notepad.exe", saveFileDialog1.FileName);
            }
        }
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //deszyfruj
        {
            string sciezka = PrivFilePath.Text;
            string privateKey = PrivKeyPath.Text;
            if (sciezka == "")
            {
                MessageBox.Show("Nie wybrano pliku, najpierw wskaż ścieżkę do pliku do zaszyfrowania");
            }
            else if (privateKey == "")
            {
                MessageBox.Show("Nie wybrano pliku klucza prywatnego, spróbuj ponownie");
            }
            else
            {
                //string privateKeyText = System.IO.File.ReadAllText(privateKey);
                string privateKeyText = System.IO.File.ReadAllText(privateKey);
                string fileText = System.IO.File.ReadAllText(sciezka);
                string encryptedText = Decrypt(fileText, privateKeyText);
                //MessageBox.Show(privateKeyText);
                //MessageBox.Show(fileText);
                //MessageBox.Show(encryptedText);
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.Filter = "Wszystkie pliki| *| Plik txt | *.txt";
                //saveFileDialog1.Filter = "Wszystkie pliki|*";
                 saveFileDialog1.Title = "Wybierz lokalizację zapisu odszyfrowanego pliku";
                 saveFileDialog1.ShowDialog();
                 if (saveFileDialog1.FileName != "")
                 {
                     using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                     {
                         AddText(fs, encryptedText);
                     }
                 }
                 MessageBox.Show("Odszyfrowano plik \n Został zapisany w lokalizacji: \n " + saveFileDialog1.FileName);
                System.Diagnostics.Process.Start("notepad.exe", saveFileDialog1.FileName);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*string sciezka = PubFilePath.Text;
            string text = System.IO.File.ReadAllText(sciezka);
            MessageBox.Show(text);*/
            //string publicKeyText = System.IO.File.ReadAllText(PubKeyPath.Text);
            //GetKeyString(publicKeyText);
        }

        private void PubKeyPath_Click(object sender, EventArgs e) //szyfruj wybierz plik
        {
            using (OpenFileDialog pubkey = new OpenFileDialog())
            {
                pubkey.Filter = "Wszystkie pliki|*";
                pubkey.Title = "Wybierz plik";
                if (pubkey.ShowDialog() != DialogResult.OK) return;
                string filePath = pubkey.FileName;
                string fileName = pubkey.SafeFileName;
                string filePathName = pubkey.FileName.Replace(pubkey.SafeFileName, "");
                PubKeyPath.Text = filePath;
            }
        }

        private void PrivKeyPath_Click(object sender, EventArgs e) //deszyfruj wybierz plik
        {
            using (OpenFileDialog privkey = new OpenFileDialog())
            {
                privkey.Filter = "Wszystkie pliki|*";
                privkey.Title = "Wybierz plik";
                if (privkey.ShowDialog() != DialogResult.OK) return;
                string filePath = privkey.FileName;
                string fileName = privkey.SafeFileName;
                string filePathName = privkey.FileName.Replace(privkey.SafeFileName, "");
                PrivKeyPath.Text = filePath;
            }
        }

        private void button4_Click(object sender, EventArgs e) //generuj klucz publiczny/prywatny
        {
            var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
            var publicKey = cryptoServiceProvider.ExportParameters(false); //Generowanie klucza publiczny
            string publicKeyString = GetKeyString(publicKey);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Plik XML|*.xml";
            saveFileDialog1.Title = "Wybierz lokalizację zapisu klucza publicznego";
            saveFileDialog1.FileName = "publickey";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog1.FileName))
                {
                    AddText(fs, publicKeyString);
                }
            }

            MessageBox.Show("Wygenerowano klucz publiczny \n Został zapisany w pliku tekstowym w lokalizacji: \n " + saveFileDialog1.FileName);
            System.Diagnostics.Process.Start("explorer.exe", saveFileDialog1.FileName);

            //var cryptoServiceProvider = new RSACryptoServiceProvider(2048); //2048 - Długość klucza
            var privateKey = cryptoServiceProvider.ExportParameters(true); //Generowanie klucza prywatnego
            string privateKeyString = GetKeyString(privateKey);
            SaveFileDialog saveFileDialog2 = new SaveFileDialog();
            saveFileDialog2.Filter = "Plik XML|*.xml";
            saveFileDialog2.Title = "Wybierz lokalizację zapisu klucza publicznego";
            saveFileDialog2.FileName = "privatekey";
            saveFileDialog2.ShowDialog();
            if (saveFileDialog2.FileName != "")
            {
                //System.IO.FileStream saveFile = (System.IO.FileStream)saveFileDialog1.OpenFile();
                using (System.IO.FileStream fs = System.IO.File.Create(saveFileDialog2.FileName))
                {
                    AddText(fs, privateKeyString);
                }
            }
            MessageBox.Show("Wygenerowano klucz prywatny \n Został zapisany w pliku XML w lokalizacji: \n " + saveFileDialog2.FileName);
            System.Diagnostics.Process.Start("explorer.exe", saveFileDialog2.FileName);


        }

        public static void AddText(System.IO.FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        private void button5_Click(object sender, EventArgs e) //generuj klucz prywatny
        {

        }

        //początek skryptu na szyfrowanie/deszyfrowanie

        public static string GetKeyString(RSAParameters publicKey)
        {

            var stringWriter = new System.IO.StringWriter();
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xmlSerializer.Serialize(stringWriter, publicKey);
            return stringWriter.ToString();
        }

        public static string Encrypt(string textToEncrypt, string publicKeyString)
        {
            var bytesToEncrypt = Encoding.UTF8.GetBytes(textToEncrypt);

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    rsa.FromXmlString(publicKeyString.ToString());
                    var encryptedData = rsa.Encrypt(bytesToEncrypt, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    return base64Encrypted;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static string Decrypt(string textToDecrypt, string privateKeyString)
        {
            var bytesToDecrypt = Encoding.UTF8.GetBytes(textToDecrypt);
            
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {

                    // server decrypting data with private key                    
                    rsa.FromXmlString(privateKeyString);
                    var resultBytes = Convert.FromBase64String(textToDecrypt);
                    var decryptedBytes = rsa.Decrypt(resultBytes, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedData;
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }


    }
}
