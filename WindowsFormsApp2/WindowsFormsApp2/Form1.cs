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
        int vt = 0;
        int ft = 0;
        string[,] sTest = new  string[200,6];
        int[] value = new int[200];
        int[] vtrue = new int[200];
        int q = 0;
        int question = 0;
        Random random = new Random();

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

                int[] Vrand = {1,2,3,4,5};
                int num = 0;
                int sInt = 0;
                for (int a = 0; a < Vrand.Length; a++)
                {
                    while (true)
                    {
                        num = random.Next(0, Vrand.Length);
                        if (a <= num)
                        {
                            sInt = Vrand[a];
                            Vrand[a] = Vrand[num];
                            Vrand[num] = sInt;
                            break;
                        }
                    }
                }

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "v1") { sTest[q, Vrand[0]] = childnode.InnerText; vtrue[q] = Vrand[0];}
                    if (childnode.Name == "v2") { sTest[q, Vrand[1]] = childnode.InnerText; }
                    if (childnode.Name == "v3") { sTest[q, Vrand[2]] = childnode.InnerText; }
                    if (childnode.Name == "v4") { sTest[q, Vrand[3]] = childnode.InnerText; }
                    if (childnode.Name == "v5") { sTest[q, Vrand[4]] = childnode.InnerText; }
                }
                q++;
            }
            

            int[] array = new int[q];
            int number = 0;
            int saveInt = 0;

            
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
            v1.Text = "v1";
            v2.Text = "v2";
            v3.Text = "v3";
            v4.Text = "v4";
            v5.Text = "v5";

            label1.Text = sTest[array[question], 0];
            if (sTest[array[question], 1] != null) { v1.Text = sTest[array[question], 1]; }
            if (sTest[array[question], 2] != null) { v2.Text = sTest[array[question], 2]; }
            if (sTest[array[question], 3] != null) { v3.Text = sTest[array[question], 3]; }
            if (sTest[array[question], 4] != null) { v4.Text = sTest[array[question], 4]; }
            if (sTest[array[question], 5] != null) { v5.Text = sTest[array[question], 5]; }

            label2.Text = "ответы: ";
            for (int i = 0; i < arr.Length; i++)
            {
                label2.Text += vtrue[arr[i]].ToString();
                label2.Text += " ";
            }

            label4.Text = "вопрос№ " + question.ToString() + " из " + q;
                //for (int i = 0; i< array.Length;i++)
                //{
                //    label1.Text += array[i].ToString();
                //    label1.Text += " ";
                //}



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void v_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (Convert.ToInt32(btn.Tag) == vtrue[arr[question]])
            {
                label3.Text = "Правильнно";
                vt++;
            }
            else
            {
                label3.Text = "Неправильнно";
                ft++;
            }
            comboBox1.Items.Add(question+1 + " " +label3.Text);

            if (question < q) { question++; }
            label4.Text = "вопрос№ " + question.ToString() + " из " + q + "  правильных: " + vt + "| неправильных: "+ ft;

            label2.Text = "ответы: ";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == question) { label2.Text += "|"; }
                label2.Text += vtrue[arr[i]].ToString();
                label2.Text += " ";
                if (i == question) { label2.Text += "|"; }
            }
            label1.Text = " ";
            v1.Text = "v1";
            v2.Text = "v2";
            v3.Text = "v3";
            v4.Text = "v4";
            v5.Text = "v5";

            label1.Text = sTest[arr[question], 0];
            if (sTest[arr[question], 1] != null) { v1.Text = sTest[arr[question], 1]; }
            if (sTest[arr[question], 2] != null) { v2.Text = sTest[arr[question], 2]; }
            if (sTest[arr[question], 3] != null) { v3.Text = sTest[arr[question], 3]; }
            if (sTest[arr[question], 4] != null) { v4.Text = sTest[arr[question], 4]; }
            if (sTest[arr[question], 5] != null) { v5.Text = sTest[arr[question], 5]; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked != true)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
