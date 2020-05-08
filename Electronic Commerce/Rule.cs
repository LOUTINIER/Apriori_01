using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Electronic_Commerce
{
    public struct RecResult
    {
        public List<int> pid;
        public List<List<string>> pInfo;
        public List<double> interest;
        public List<string> header;
    }
    class Rule
    {
        public List<Apriori> allSets = new List<Apriori>();
        public List<double> interest_2 = new List<double>();
        public RecResult outResult = new RecResult();
        public double minInterest;
        public Rule(double minSup, double minInt, int untilWhichSet)
        {
            outResult.pid = new List<int>();
            outResult.pInfo = new List<List<string>>();
            outResult.interest = new List<double>();
            outResult.header = new List<string>();
            minInterest = minInt;

            Apriori.minSupPer = minSup;
            allSets = Apriori.GetAllSets(allSets, untilWhichSet);
        }

        public void InitInterestSet()
        {
            interest_2.Clear();
            if (allSets.Count >= 2)
            {
                for (int i = 0; i < allSets[1].freqSet.freqSet.Count; ++i)
                {
                    int j0 = 0, j1 = 0;
                    for (int j = 0; j < allSets[0].freqSet.freqSet.Count; ++j)
                    {
                        if (allSets[1].freqSet.freqSet[i][0] == allSets[0].freqSet.freqSet[j][0]) j0 = j;
                        if (allSets[1].freqSet.freqSet[i][1] == allSets[0].freqSet.freqSet[j][0]) j1 = j;
                    }
                    double result = allSets[1].freqSet.supCount[i] * 1.0 / allSets[0].freqSet.supCount[j0]
                        / allSets[0].freqSet.supCount[j1] * Apriori.inDataSet.uid.Count;
                    // 剪枝
                    if (result >= minInterest)
                        interest_2.Add(result);
                }
            }
            else
            {
                MessageBox.Show("没有频繁二项集的数据，将无法进行推荐，可尝试将数据量变大，范围变小或者将支持度调低。");
            }
        }

        public void Rec(int amount, int input)
        {
            outResult.pid.Clear();
            outResult.interest.Clear();
            if (amount > interest_2.Count)
                MessageBox.Show("推荐个数大于可推荐个数。");
            else
            {
                // 拿出频繁二项集
                FreqSet set_2 = allSets[1].freqSet;
                // 剪掉小于minInt兴趣度的数据
                for (int i = 0; i < interest_2.Count; ++i) 
                {
                    // 对应的频繁项是否有input
                    if (set_2.freqSet[i].Contains(input))
                    {
                        // 先看有没有达到需要的个数
                        if (outResult.pid.Count < amount)
                        {
                            outResult.pid.Add(set_2.freqSet[i][1 - set_2.freqSet[i].IndexOf(input)]);
                            outResult.interest.Add(interest_2[i]);
                        }
                        // 有的话看看他的兴趣度能不能上榜
                        else
                            // 将其与已有结果比较
                            for (int j = 0; j < amount; ++j)
                                // 如果发现上榜：大于某个已有结果
                                if (interest_2[i] >= outResult.interest[j])
                                {
                                    outResult.pid.Insert(j, set_2.freqSet[i][1 - set_2.freqSet[i].IndexOf(input)]);
                                    outResult.interest.Insert(j, interest_2[i]);
                                    outResult.pid.RemoveAt(amount);
                                    outResult.interest.RemoveAt(amount);
                                    break;
                                }
                    }
                }
            }
        }

        public void CompleteInfo(string path)
        {
            outResult.header.Clear();
            outResult.pInfo.Clear();
            using (CsvFileReader reader = new CsvFileReader(path)) 
            {
                CsvRow row = new CsvRow();
                reader.ReadRow(row);
                outResult.header.AddRange(row);
                while(reader.ReadRow(row))
                {
                    for (int i = 0; i < outResult.pid.Count; ++i) 
                    {
                        if (outResult.pid[i] == int.Parse(row[0]))
                        {
                            List<string> tmp = new List<string>();
                            tmp.AddRange(row);
                            tmp.Add("兴趣度为：" + outResult.interest[i]);
                            outResult.pInfo.Add(tmp);
                        }
                    }
                }
            }
        }

        
    }
}
