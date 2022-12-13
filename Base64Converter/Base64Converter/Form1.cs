using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (UserText.Text == "")
            {
                MessageBox.Show("Nie można przekonwertować:\n Nie wprowadzono tekstu do pola, spróbuj ponownie");
            } else
            {
                string userText = UserText.Text;
                byte[] bytes = Encoding.UTF8.GetBytes(userText);
                string output = Base64ConverterMethods.Base64Convert(bytes);
                Base64Output.Text = output;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (Base64Output.Text == "")
            {
                MessageBox.Show("Nie można zapisać:\n Nie przekonwertowano tekstu, spróbuj ponownie");
            } else
            {
                 SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.Filter = "Wszystkie pliki| *| Plik txt | *.txt";
                 saveFileDialog1.Title = "Wybierz lokalizację zapisu przekonwertowanego tekstu";
                 saveFileDialog1.ShowDialog();
                 if (saveFileDialog1.FileName != "")
                 {
                     using (FileStream fs = File.Create(saveFileDialog1.FileName))
                     {
                         AddText(fs, Base64Output.Text);
                     }
                 }
                MessageBox.Show("Odszyfrowano plik \n Został zapisany w lokalizacji: \n " + saveFileDialog1.FileName);
                System.Diagnostics.Process.Start("explorer.exe", saveFileDialog1.FileName);
            }
        }

        private void CovertB64Button_Click(object sender, EventArgs e)
        {
            if (Base64Output.Text == "")
            {
                MessageBox.Show("Nie można przekonwertować:\n Nie wprowadzono tekstu, spróbuj ponownie");
            }
            else
            {
                string B64Input = Base64Output.Text;

                byte[] output = Base64ConverterMethods.FromBase64Converter(B64Input);
                string sOutput = Encoding.UTF8.GetString(output);
                UserText.Text = sOutput;
            }
        }
        private static char[] Base64Tab = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '/', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static class Base64ConverterMethods
        {
            // private static readonly char[] Base64Tab = new[] { '0', '1', '2', '3', '4','5','6','7','8','9','+','/','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
            public static string Base64Convert(byte[] textToConvert) //z pierwszego pola na drugie do Base64
            {
                string b64String = "";
                string bits = "";

                foreach (byte bt in textToConvert)
                {
                    bits = bits + Convert.ToString(bt, 2).PadLeft(8, '0');
                }

                int padLength = 24 - bits.Length % 24;
                bits += new string('0', padLength);
                int checkSings = padLength / 6;
                int temp = 0;
                while (temp < bits.Length - (checkSings * 6))
                {
                    string subs = bits.Substring(temp, 6);
                    int subsToInt = Convert.ToInt32(subs, 2);
                    b64String = b64String + Base64Tab[subsToInt];
                    temp = temp + 6;
                }
                b64String = b64String + new string('=', checkSings);
                return b64String;
            }


            public static byte[] FromBase64Converter(string b64String)
            {
                int strLength = b64String.Length;
                while (b64String[strLength - 1] == '=')
                {
                    b64String = b64String.Substring(0, strLength - 1);
                    strLength--;
                }
                string bits = "";
                for (int i = 0; i < strLength; i++)
                {
                    int transToInt = Array.IndexOf(Base64Tab, b64String[i]);
                    bits = bits + Convert.ToString(transToInt, 2).PadLeft(6, '0');
                }

                int countZeroes = bits.Length % 8;
                bits = bits.Substring(0, bits.Length - countZeroes);
                byte[] tempbytes = new byte[bits.Length / 8];
                int count = 0;
                int tempcount = 0;
                while (count < bits.Length)
                {
                    string convertPart = bits.Substring(count, 8);
                    tempbytes[tempcount] = Convert.ToByte(convertPart, 2);
                    tempcount++;
                    count = count + 8;
                }
                return tempbytes;
            }

        }
        public static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
