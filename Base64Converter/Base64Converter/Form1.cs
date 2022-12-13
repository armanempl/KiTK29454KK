using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                string wynik = Base64ConverterMethods.Base64Convert(UserText.Text);
                MessageBox.Show(wynik);
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (Base64Output.Text == "")
            {
                MessageBox.Show("Nie można zapisać:\n Nie przekonwertowano tekstu, spróbuj ponownie");
            } else
            {

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

            }
        }

        public static class Base64ConverterMethods
        {
            private static char[] Base64Tab = new[] { '0', '1', '2', '3', '4','5','6','7','8','9','+','/','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' };
        public static string Base64Convert(string tab)
            {
                string b64String = "";
                string bits = "";

                foreach(byte bt in tab)
                {
                    bits = bits + Convert.ToString(bt, 2).PadLeft(8,'0');
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
        }


    }
}
