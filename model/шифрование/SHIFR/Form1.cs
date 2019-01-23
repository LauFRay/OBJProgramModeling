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
    public partial class Form1 : Form
    {
        private char[] alfavit = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'//, '.', '-', ',', ' ' 
        };
   
        public Form1()
        {
            InitializeComponent();
        }
        
        private string Cezar(string sentence,int number)
        {
           sentence = sentence.ToUpper();

            string result = string.Empty;
  
            for (int i = 0; i < sentence.Length; i++)
            {
                for(int j = 0; j < alfavit.Length; j++)
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
                    else if(sentence[i].Equals(' '))
                    {
                        result += " ";
                        break;
                    }
                }

               
            }

            return result;
        }

        private string Newshifr(string sentence)
        {
            sentence = sentence.ToUpper();

            string result = string.Empty;

            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (alfavit[j].Equals(sentence[i]))
                    {
                            result += j/6 +'/'+ j % 6;
                            break;
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

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    label1.Text = Cezar(textBox1.Text, Convert.ToInt32(numericUpDown1.Value));
                    break;
                case 1:
                    label1.Text = Newshifr(textBox1.Text);
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Cezar(textBox1.Text, Convert.ToInt32(-numericUpDown1.Value));
        }
    }
}
