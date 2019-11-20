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

namespace TEST_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();
        class TEST
        {
            public string[] question = new string[200];
            public string[,] variant = new string[200,5];
            public int[] truevariant = new int[200];
            public int testsize = 0;
        }
        
        TEST Test = new TEST();
        int Qnum = 0;
        int[] TestSequence = new int[200];
        int[] TestResult = new int[200];

        public bool TestOpen(bool rand)
        {
            bool BeginTest = false;
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(OPFD.FileName);
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null) Test.question[Test.testsize] = attr.Value;
                }

                int[] Vrand = { 0, 1, 2, 3, 4 };
                if (rand == true)
                {
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
                }

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "v1") { Test.variant[Test.testsize, Vrand[0]] = childnode.InnerText; Test.truevariant[Test.testsize] = Vrand[0]; }
                    if (childnode.Name == "v2") { Test.variant[Test.testsize, Vrand[1]] = childnode.InnerText; }
                    if (childnode.Name == "v3") { Test.variant[Test.testsize, Vrand[2]] = childnode.InnerText; }
                    if (childnode.Name == "v4") { Test.variant[Test.testsize, Vrand[3]] = childnode.InnerText; }
                    if (childnode.Name == "v5") { Test.variant[Test.testsize, Vrand[4]] = childnode.InnerText; }
                }
                Test.testsize++;
            }
            BeginTest = true;


            return BeginTest;
        }

        public int[] randomiseQuestion(int[] sequence)
        {
            int[] QuestionSequence = sequence;
            int number = 0;
            int saveInt = 0;


            for (int i = 0; i < Test.testsize; i++)
            {
                QuestionSequence[i] = i;
            }
            for (int a = 0; a < Test.testsize; a++)
            {
                while (true)
                {
                    number = random.Next(0, Test.testsize);
                    if (a <= number)
                    {
                        saveInt = QuestionSequence[a];
                        QuestionSequence[a] = QuestionSequence[number];
                        QuestionSequence[number] = saveInt;
                        break;
                    }
                }
            }

            return QuestionSequence;
        }

        public bool TestBegin(int numQ,int[] sequence)
        {
            bool endTest = false;
            if (Qnum < Test.testsize)
            {
                question.Text = Test.question[sequence[numQ]];

                v1.Text = Test.variant[sequence[numQ], 0];
                v2.Text = Test.variant[sequence[numQ], 1];
                v3.Text = Test.variant[sequence[numQ], 2];
                v4.Text = Test.variant[sequence[numQ], 3];
                v5.Text = Test.variant[sequence[numQ], 4];
            }
            else
            {
                endTest = true;
            }

            return endTest;
        }

        public bool VariantСheck(int numV)
        {
            bool result = false;

            if (numV == Test.truevariant[TestSequence[Qnum]])
            {
                result = true;
                if (TestResult[Qnum]!= 3)
                {
                    TestResult[Qnum] = 1;
                }
            }
            else
            {
                if (TestResult[Qnum] != 3)
                {
                    TestResult[Qnum] = 2;
                }
            }

            return result;
        }

        public string Testinfo()
        {
            string status = null;
            status += "вопрос: " + Qnum + " из: " + Test.testsize; 

            return status;
        }

        public void AddHistory()
        {
            for (int i = 0; i < Test.testsize; i++)
            {
                TestHistory.Nodes.Add((i+1) +" ");
                TestHistory.Nodes[i].Text += Test.question[TestSequence[i]]; 
            }
        }

        public void UpdateHistory()
        {
            TestHistory.Nodes.Clear();
            AddHistory();
            for (int i = 0; i < Test.testsize;i++)
            {
                if (TestResult[i] == 1) { TestHistory.Nodes[i].Text = (i + 1) + " Правельно"; }
                if (TestResult[i] == 2) {
                    TestHistory.Nodes[i].Text = (i + 1) + " Неравельно";
                    TestHistory.Nodes[i].Nodes.Add("");
                    TestHistory.Nodes[i].Nodes[0].Text = Test.question[TestSequence[i]];
                    TestHistory.Nodes[i].Nodes.Add("");
                    TestHistory.Nodes[i].Nodes[1].Text = Test.variant[TestSequence[i],Test.truevariant[TestSequence[i]]];
                }
                if (TestResult[i] == 3) {
                    TestHistory.Nodes[i].Text = (i + 1) + " Подглядел";
                    TestHistory.Nodes[i].Nodes.Add("");
                    TestHistory.Nodes[i].Nodes[0].Text = Test.question[TestSequence[i]];
                    TestHistory.Nodes[i].Nodes.Add("");
                    TestHistory.Nodes[i].Nodes[1].Text = Test.variant[TestSequence[i], Test.truevariant[TestSequence[i]]];
                }
            }

        }

        private void Form_Resize(object sender, EventArgs e)
        {
            v1.Top = 15 ; v1.Height = (panel_Variant.Height / 5) - 5;
            v2.Top = v1.Top + v1.Height; v2.Height = (panel_Variant.Height / 5) - 5;
            v3.Top = v2.Top + v1.Height; v3.Height = (panel_Variant.Height / 5) - 5;
            v4.Top = v3.Top + v1.Height; v4.Height = (panel_Variant.Height / 5) - 5;
            v5.Top = v4.Top + v1.Height; v5.Height = (panel_Variant.Height / 5) - 5;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width += 1;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Test = new TEST();
            Qnum = 0;
            TestSequence = new int[200];
            TestResult = new int[200];
            btnOpen.Text = "OPEN(false)";
            OPFD.ShowDialog();
            bool rand = randVariant.Checked;
            btnOpen.Text = "OPEN(" + TestOpen(rand).ToString() + ")";
            
            TestBegin(Qnum,randomiseQuestion(TestSequence));
            btnHelp.Text = "ОТВЕТ";
            this.Text = Testinfo();
            AddHistory();
        }
        
        private void v_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            variantValue.Text = VariantСheck(Convert.ToInt32(btn.Tag)).ToString();
            Qnum++;
            this.Text = Testinfo();
            if (TestBegin(Qnum, TestSequence)==true)
            {
                this.Text += "       конец         ";
            }
            btnHelp.Text = "ОТВЕТ";
            UpdateHistory();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            btnHelp.Text = (Test.truevariant[TestSequence[Qnum]]+1).ToString();
            TestResult[Qnum] = 3;
        }
    }
}
