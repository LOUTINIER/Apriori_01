using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Commerce
{
    public partial class Form1 : Form
    {
        Rule rule;
        string openPath = "C:\\Users\\13614\\OneDrive\\4\\电子商务\\实验";
        public void PrintOnTextBox(string a) { textBox.AppendText(a); }
        public Form1()
        {
            InitializeComponent();
            
            minconf.Enabled = false;
            ConfRecBtn.Enabled = false;

            IntRecBtn.Enabled = false;
            ShowFreqBtn.Enabled = false;
            GenFreqBtn.Enabled = false;
            Gen2FreqBtn.Enabled = false;
            ShowRuleBtn.Enabled = false;

            minsup.Enabled = false;
            minint.Enabled = false;
            recnum.Enabled = false;
            productid.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 按兴趣度推荐商品
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(productid.Text, out int a) &&
                int.TryParse(recnum.Text, out int b))
            {
                rule.Rec(b, a);
                string path = openPath.Substring(0, openPath.LastIndexOf("\\")) + "\\EX1_ProductInfo.csv";
                string picPath = openPath.Substring(0, openPath.LastIndexOf("\\") + 1);
                if (System.IO.File.Exists(path))
                {
                    textBox.AppendText("输入pid=" + a.ToString() + "的推荐结果" + Environment.NewLine);
                    rule.CompleteInfo(path);
                    List<string> picInfo = new List<string>();
                    int resultCnt = rule.outResult.pid.Count;
                    if (resultCnt != 0)
                    {
                        if (resultCnt == b)
                            textBox.AppendText("成功推荐以下" + b.ToString() + "件商品：" + Environment.NewLine);
                        else textBox.AppendText("推荐不足" + b.ToString() + "件商品。推荐了" + resultCnt.ToString() + "件商品：" + Environment.NewLine);
                        string outA = "";
                        for (int j = 0; j < rule.outResult.header.Count; ++j)
                            outA += string.Format("{0,-20}", rule.outResult.header[j]);
                        outA += Environment.NewLine;
                        for (int i = 0; i < rule.outResult.pInfo.Count; ++i)
                        {
                            picInfo.Add("");
                            for (int j = 0; j < rule.outResult.pInfo[i].Count; ++j)
                            {
                                outA += string.Format("{0,-20}", rule.outResult.pInfo[i][j]);
                                if (j != rule.outResult.pInfo[i].Count - 1) picInfo[i] += rule.outResult.header[j];
                                 picInfo[i] +=  ": " + rule.outResult.pInfo[i][j] + "   ";
                            }
                            outA += Environment.NewLine;
                        }
                        outA += Environment.NewLine;
                        textBox.AppendText(outA);
                        new ShowPic(picPath, rule.outResult.pid, picInfo).Show();
                    }
                    else { textBox.AppendText("无推荐商品。" + Environment.NewLine); }
                }
                else textBox.AppendText("商品信息文件路径无效，请将EX1_ProductInfo.csv文件放到默认生成路径下。" + Environment.NewLine);

            }
            else { textBox.AppendText("请检查推荐输入是否有误！" + Environment.NewLine); }
        }

        // 生成所有频繁项集
        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(minsup.Text, out double a) &&
                double.TryParse(minint.Text, out double b)) 
            {
                // 这个按钮不做限制
                rule = new Rule(a / 100, b / 100, 0x3f3f3f);
                textBox.AppendText("成功生成所有频繁项集。" + Environment.NewLine);
                ShowRuleBtn.Enabled = true;
                ShowFreqBtn.Enabled = true;
                minint.Enabled = true;
                IntRecBtn.Enabled = false;
                recnum.Enabled = false;
                productid.Enabled = false;
            }
            else { textBox.AppendText("请检查阈值输入是否有误！" + Environment.NewLine); }
        }

        // 生成数据按钮
        private void button1_Click_1(object sender, EventArgs e)
        { 
            if (int.TryParse(minuid.Text, out int a) &&
                int.TryParse(maxuid.Text, out int b) &&
                int.TryParse(minpid.Text, out int c) &&
                int.TryParse(maxpid.Text, out int d) &&
                int.TryParse(dataAmount.Text, out int h))
            {
                folderBrowserDialog1.SelectedPath = "C:\\Users\\13614\\OneDrive\\4\\电子商务\\实验";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowserDialog1.SelectedPath;
                    Apriori.GenData(a, b, c, d, h, path);
                    textBox.AppendText("成功在\"" + path + "\"生成EX1_Order.csv文件和EX1_ProductInfo.csv文件。" + Environment.NewLine);
                }
            }
            else
            { textBox.AppendText("请检查数据输入是否有误！" + Environment.NewLine); }
            ShowFreqBtn.Enabled = false;
            ShowRuleBtn.Enabled = false;
            IntRecBtn.Enabled = false;
            GenFreqBtn.Enabled = false;
            Gen2FreqBtn.Enabled = false;
        }

        // 读入数据按钮
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = openPath;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "EX1_Order.csv";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK && File.Exists(openFileDialog1.FileName.ToString())) 
            {
                openPath = openFileDialog1.FileName.ToString();
                Apriori.SetData(openPath);
                textBox.AppendText("成功从\"" + openPath + "\"读入数据。" + Environment.NewLine);
                GenFreqBtn.Enabled = true;
                Gen2FreqBtn.Enabled = true;
                minsup.Enabled = true;
                ShowFreqBtn.Enabled = false;
                ShowRuleBtn.Enabled = false;
                IntRecBtn.Enabled = false;
                minint.Enabled = false;
                recnum.Enabled = false;
                productid.Enabled = false;
            }
            else { textBox.AppendText("请检查文件是否存在！" + Environment.NewLine); }
        }

        // 展示频繁项集
        private void button6_Click(object sender, EventArgs e)
        {
            if (rule.allSets.Count == 0)
                textBox.AppendText("数据没有产生频繁项集。" + Environment.NewLine);
            else
            {
                string a = "频繁项集：" + Environment.NewLine;
                for (int i = 0; i < rule.allSets.Count; ++i)
                {
                    a += rule.allSets[i].K.ToString() + "项集：" + Environment.NewLine;
                    for (int j = 0; j < rule.allSets[i].freqSet.freqSet.Count; ++j)
                    {
                        string tmpa = "{";
                        for (int k = 0; k < rule.allSets[i].freqSet.freqSet[j].Count; ++k)
                        {
                            tmpa += rule.allSets[i].freqSet.freqSet[j][k].ToString();
                            if (k != rule.allSets[i].freqSet.freqSet[j].Count - 1) tmpa += "，";
                        }
                        tmpa += "} 支持度：" + rule.allSets[i].freqSet.supCount[j].ToString();
                        a += string.Format("{0," + (-rule.allSets[i].K * 4 - 10) + "}", tmpa);
                        if ((j + 1) % (9 - rule.allSets[i].K) == 0) a += Environment.NewLine;
                    }
                    a += Environment.NewLine;
                }
                textBox.AppendText(a);
            }
        }

        // 生成并展示关联规则
        private void button7_Click(object sender, EventArgs e)
        {
            if (double.TryParse(minint.Text, out double tmpInterest)) 
            {
                rule.minInterest = tmpInterest / 100;
                rule.InitInterestSet();
                string a = "成功生成关联规则：" + Environment.NewLine;
                for (int i = 0; i < rule.interest_2.Count; ++i)
                {
                    a += string.Format("{0,-30}", "{" + rule.allSets[1].freqSet.freqSet[i][0].ToString() + "，"
                        + rule.allSets[1].freqSet.freqSet[i][1].ToString() + "}"
                         + " 兴趣度：" + rule.interest_2[i].ToString())+"  ";
                    if ((i + 1) % 5 == 0) a += Environment.NewLine;
                }
                a += Environment.NewLine;
                textBox.AppendText(a);
                IntRecBtn.Enabled = true;
                recnum.Enabled = true;
                productid.Enabled = true;
            }
            else { textBox.AppendText("请检查兴趣度阈值输入是否有误！" + Environment.NewLine); }
        }

        // 生成到频繁二项集
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (double.TryParse(minsup.Text, out double a) &&
                double.TryParse(minint.Text, out double b))
            {
                // 只生成到2项集
                rule = new Rule(a / 100, b / 100, 2);
                textBox.AppendText("成功生成到频繁2项集。" + Environment.NewLine);
                ShowRuleBtn.Enabled = true;
                ShowFreqBtn.Enabled = true;
                minint.Enabled = true;
                IntRecBtn.Enabled = false;
                recnum.Enabled = false;
                productid.Enabled = false;
            }
            else { textBox.AppendText("请检查阈值输入是否有误！" + Environment.NewLine); }
        }

        private void minsup_TextChanged(object sender, EventArgs e)
        {
            ShowFreqBtn.Enabled = false;
            ShowRuleBtn.Enabled = false;
            IntRecBtn.Enabled = false;
            minint.Enabled = false;
            recnum.Enabled = false;
            productid.Enabled = false;
        }

        private void minint_TextChanged(object sender, EventArgs e)
        {
            IntRecBtn.Enabled = false;
            recnum.Enabled = false;
            productid.Enabled = false;
        }
    }
}
