using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] AESKey;
        byte[] AESIV;
        byte[] encryptedText;
        string decryptedText;
        private void GenerateKeyIV_Click(object sender, EventArgs e)
        {
            using (RijndaelManaged rijndael = new RijndaelManaged())
            {
                rijndael.GenerateKey();
                rijndael.GenerateIV();
                AESKey = rijndael.Key;
                AESIV = rijndael.IV;
                KeyText.Text = Convert.ToBase64String(AESKey);
                IVText.Text = Convert.ToBase64String(AESIV);

            }

        }

        public static byte[] AESEncrypt(string text, byte[] Key, byte[] IV)
        {
            byte[] tempEnc;
            using (RijndaelManaged rij = new RijndaelManaged())
            {
                rij.Key = Key;
                rij.IV = IV;
                ICryptoTransform encrypt = rij.CreateEncryptor(rij.Key, rij.IV);
                using (MemoryStream msEnc = new MemoryStream())
                {
                    using (CryptoStream csEnc = new CryptoStream(msEnc, encrypt, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEnc = new StreamWriter(csEnc))
                        {
                            swEnc.Write(text);
                        }
                    tempEnc = msEnc.ToArray();
                    }
                }
            }
            return tempEnc;
        }

        public static string AESDecrypt(byte[] encryptedtext, byte[] Key, byte[] IV)
        {
            string decryptedText = null;

            using (RijndaelManaged rijd = new RijndaelManaged())
            {
                rijd.Key = Key;
                rijd.IV = IV;

                ICryptoTransform decrypt = rijd.CreateDecryptor(rijd.Key, rijd.IV);
                using (MemoryStream msDc = new MemoryStream(encryptedtext))
                {
                    using (CryptoStream csDc = new CryptoStream(msDc, decrypt, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDc = new StreamReader(csDc))
                        {
                            decryptedText = srDc.ReadToEnd();
                        }
                    }
                }
            }
            return decryptedText;
        
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (KeyText.Text == "" || IVText.Text == "")
            {
                MessageBox.Show("Nie wygenerowano klucza i wektora inicjującego, spróbuj ponownie");
            }
            else if (UserInput.Text == "")
            {
                MessageBox.Show("Nie wprowadzono tekstu do zaszyfrowania, spróbuj ponownie");
            } else
            {
                byte[] enc = AESEncrypt(UserInput.Text, AESKey, AESIV);
                encryptedText = enc;
                AESOutput.Text = Convert.ToBase64String(enc);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (KeyText.Text == "" || IVText.Text == "")
            {
                MessageBox.Show("Nie wygenerowano klucza i wektora inicjującego, spróbuj ponownie");
            }
            else if (AESOutput.Text == "")
            {
                MessageBox.Show("Nie wprowadzono ciągu znaków do odszyfrowania, spróbuj ponownie");
            } else { 
            string dec = AESDecrypt(encryptedText, AESKey, AESIV);
            decryptedText = dec;
            UserInput.Text = dec;
        }
        }
        public static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
