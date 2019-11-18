using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] sTest = new  string[200,6];
        int[] value = new int[200];
        int q = 0;
        int question = 0;

        int[] arr; 

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("C://Users/Acer/Documents/test/XMLFile1.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) sTest[q,0]= attr.Value;
                }
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "v1") { sTest[q, 1] = childnode.InnerText; }
                    if (childnode.Name == "v2") { sTest[q, 2] = childnode.InnerText; }
                    if (childnode.Name == "v3") { sTest[q, 3] = childnode.InnerText; }
                    if (childnode.Name == "v4") { sTest[q, 4] = childnode.InnerText; }
                    if (childnode.Name == "v5") { sTest[q, 5] = childnode.InnerText; }
                }
                q++;
            }
            

            int[] array = new int[q];
            int number = 0;
            int saveInt = 0;

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i ;
            }
            for (int a = 0; a < array.Length; a++)
            {
                while (true)
                {
                    number = random.Next(0, array.Length);
                    if (a <= number)
                    {
                        saveInt = array[a];
                        array[a] = array[number];
                        array[number] = saveInt;
                        break;
                    }
                }
            }
            arr = array;

            label1.Text = " ";
            checkedListBox1.Items.Clear();

            label1.Text = sTest[array[0], 0];
            for (int j = 1; j <= 5; j++)
            {
                if (sTest[array[question], j] != null)
                {
                    checkedListBox1.Items.Add(sTest[array[question], j]);
                }
            }
            //for (int i = 0; i< array.Length;i++)
            //{
            //    label1.Text += array[i].ToString();
            //    label1.Text += " ";
            //}



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    checkedListBox1.SetItemChecked(i, false);
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
                if (question < arr.Length)
                question++;
                label1.Text = " ";
                checkedListBox1.Items.Clear();

                label1.Text = sTest[arr[0], 0];
                for (int j = 1; j <= 5; j++)
                {
                    if (sTest[arr[question], j] != null)
                    {
                        checkedListBox1.Items.Add(sTest[arr[question], j]);
                    }
                }
            }
        }
    }
}
