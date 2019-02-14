using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHIFR
{
    public partial class ShCezar : Form
    {
        public ShCezar()
        {
            InitializeComponent();
        }
        al

        private string Cezar(string sentence, int number)
        {
            sentence = sentence.ToUpper();

            string result = string.Empty;

            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (alfavit[j].Equals(sentence[i]))
                    {
                        if ((j + number) >= 0)
                        {
                            Math.DivRem(j + number, alfavit.Length, out int IndexOfWord);
                            result += alfavit.ElementAt(IndexOfWord);
                            break;
                        }
                        else
                        {
                            result += alfavit.ElementAt(alfavit.Length + number);
                            break;
                        }

                    }
                    else if (sentence[i].Equals(' '))
                    {
                        result += " ";
                        break;
                    }
                }


            }

            return result;
        }

        private void Decipher_Click(object sender, EventArgs e)
        {

        }

        private void Cipher_Click(object sender, EventArgs e)
        {

        }
    }
}
