using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Commerce
{
    public struct InDataSet
    {
        public List<int> uid;
        public List<List<int>> productIds;
    }
    public struct FreqSet
    {
        public List<int> supCount;
        public List<List<int>> freqSet;
    }
    class Apriori
    {
        public int K;
        public FreqSet freqSet = new FreqSet();
        static public InDataSet inDataSet = new InDataSet();
        public static double minSupPer;
        public Apriori(int k)
        { 
            K = k;
            freqSet.freqSet = new List<List<int>>();
            freqSet.supCount = new List<int>();
        }
        static public void GenData(int minu, int maxu, int minp, int maxp, int dAmout, string path)
        {
            Random random = new Random();
            string[] tmpStrings = new string[60];
            for (int i = 0; i < 60; ++i) tmpStrings[i] = (random.NextDouble() * 10000).ToString().Substring(0, 7);
            // 内容取的值
            string[][] info = new string[][] {
                new string[]{ "新宝岛", "Forever", "Shelter", "风之歌", "August","ily","petals","Your_Eyes","Slow_Slow","如果","一路向北"},
                new string[]{ "Marry_E","Sanfo_Sel","Jill_ki","Sun","Fox-it","hillForU","MyName","Rf&AA","Nopara"},
                tmpStrings,
                new string[]{"华语","经典","交响","古典","ACG","港台","流行","R&B","嘻哈","BigRoom","FutureBass","欧美","儿歌","Trap"},
                new string[]{"44100Hz","22050Hz","48000Hz","96000Hz"},
                new string[]{"128","192","320"}
            };
            using (CsvFileWriter writer = new CsvFileWriter(path+"\\EX1_Order.csv"))
            {
                CsvRow header = new CsvRow();
                header.Add("u_id");
                header.Add("p_id");
                writer.WriteRow(header);
                for (int i = 0; i < dAmout; ++i)
                {
                    CsvRow row = new CsvRow();
                    row.Add(String.Format("{0}", random.Next(minu, maxu)));
                    row.Add(String.Format("{0}", random.Next(minp, maxp)));
                    writer.WriteRow(row);
                }
            }
            using (CsvFileWriter writer = new CsvFileWriter(path+"\\EX1_ProductInfo.csv"))
            {
                CsvRow header = new CsvRow();
                header.Add("p_id");
                header.Add("p_name");
                header.Add("p_author");
                header.Add("p_price");
                header.Add("p_style");
                header.Add("p_sampling_rate");
                header.Add("p_bit_rate");
                writer.WriteRow(header);
                for (int i = minp; i < maxp; ++i)
                {
                    CsvRow row = new CsvRow();
                    row.Add(i.ToString());
                    for (int j = 0; j < 6; ++j)
                        row.Add(info[j][random.Next(info[j].Length)]);
                    writer.WriteRow(row);
                }
            }
        }

        static public void SetData(string path)
        {
            Apriori.inDataSet.productIds = new List<List<int>>();
            Apriori.inDataSet.uid = new List<int>();
            using (CsvFileReader reader = new CsvFileReader(path))
            {
                CsvRow row = new CsvRow();
                reader.ReadRow(row);
                while (reader.ReadRow(row))
                {
                    if (int.TryParse(row[0], out int row0) && int.TryParse(row[1], out int row1))
                    {
                        if (!inDataSet.uid.Contains(row0))
                        {
                            inDataSet.uid.Add(row0);
                            inDataSet.productIds.Add(new List<int> { row1 });
                        }
                        else
                        {
                            int index = inDataSet.uid.IndexOf(row0);
                            if (!inDataSet.productIds[index].Contains(row1))//剪掉完全重复的数据
                                inDataSet.productIds[index].Add(row1);
                        }
                    }
                    //  else
                      //  MessageBox.Show("检测到该行数据不合法：" + row[0].ToString() + row[1].ToString() + Environment.NewLine);
                }
            }
        }

        static public List<Apriori> GetAllSets(List<Apriori> allSets,int untilWhichSet)
        {
            Apriori set = new Apriori(1);
            set.GetFirstItemset();
            while (set.freqSet.freqSet.Count > 0 && allSets.Count < untilWhichSet)
            {
                allSets.Add(set);
                set = set.GetNextItemset();
            }
            return allSets;
        }



        // 私有方法

        private void GetFirstItemset()
        {
            freqSet.freqSet.Clear();
            freqSet.supCount.Clear();
            List<int> appearedValue = new List<int>();
            K = 1;
            // Apriori retObj = new Apriori(1);
            // 对每一个出现的项计数得到频繁1项集
            for (int k = 0; k < inDataSet.uid.Count; ++k)
            {
                for (int l = 0; l < inDataSet.productIds[k].Count; ++l)
                {
                    if (!appearedValue.Contains(inDataSet.productIds[k][l]))
                    {
                        if (appearedValue.Count != 0)
                        {
                            int left = 0, right = appearedValue.Count - 1;
                            while (left <= right)
                            {
                                int middle = (left + right) / 2;
                                if (inDataSet.productIds[k][l] < appearedValue[middle]) right = middle - 1;
                                else left = middle + 1;
                            }
                            appearedValue.Insert(left, inDataSet.productIds[k][l]);
                            // retObj.freqSet.supCount.Insert(left, 1);
                            freqSet.supCount.Insert(left, 1);
                        }
                        else
                        {
                            appearedValue.Add(inDataSet.productIds[k][l]);
                            // retObj.freqSet.supCount.Add(1);
                            freqSet.supCount.Add(1);
                        }
                    }
                    else
                    {
                        // retObj.freqSet.supCount[appearedValue.IndexOf(inDataSet.productIds[k][l])] += 1;
                        freqSet.supCount[appearedValue.IndexOf(inDataSet.productIds[k][l])] += 1;
                    }
                }
            }
            // 剪掉非频繁项
            for (int i = 0; i < appearedValue.Count;)
            {
                // if (retObj.freqSet.supCount[i] >= Apriori.minSupPer * inDataSet.uid.Count)
                if (freqSet.supCount[i] >= minSupPer * inDataSet.uid.Count)
                {
                    // retObj.freqSet.freqSet.Add(new List<int> { appearedValue[i] });
                    freqSet.freqSet.Add(new List<int> { appearedValue[i] });
                    i += 1;
                }
                else
                {
                    // retObj.freqSet.supCount.RemoveAt(i);
                    freqSet.supCount.RemoveAt(i);
                    appearedValue.RemoveAt(i);
                }
            }
        }

        private Apriori GetNextItemset()
        {
            Apriori retObj = new Apriori(K + 1);
            retObj.GetCandidateSet(this); // this扩展到retObj的候选项集
            retObj.CalSupCount();
            return retObj;
        }

        // 计算支持度并依据支持度剪枝
        private void CalSupCount()
        {
            // 计算支持度
            // 遍历每个原始数据
            for (int i = 0; i < freqSet.freqSet.Count; ++i)
                for (int j = 0; j < inDataSet.productIds.Count; ++j)
                    if (ContainSet(inDataSet.productIds[j], freqSet.freqSet[i])) freqSet.supCount[i] += 1;

            // 减枝
            for (int i = 0; i < freqSet.freqSet.Count;)
            {
                if (freqSet.supCount[i] < minSupPer * inDataSet.uid.Count)
                {
                    freqSet.supCount.RemoveAt(i);
                    freqSet.freqSet.RemoveAt(i);
                }
                else i += 1;
            }
        }

        private void GetCandidateSet(Apriori SrcSet)
        {
            // 组合得到K+1集
            // 组合方法是两个项0~k-2的元素相等的话，那么就能产生新项{0~k-2，第一项k-1，第二项k-1}
            // 找出频繁项集内的两个项尝试组合
            for (int i = 0; i < SrcSet.freqSet.freqSet.Count; ++i)
                for (int j = i + 1; j < SrcSet.freqSet.freqSet.Count; ++j)
                    // 对于每个频繁项集内的元素
                    for (int k = 0; k < SrcSet.K; ++k)
                        // 如果两个项第k个元素相等
                        if (SrcSet.freqSet.freqSet[i][k] != SrcSet.freqSet.freqSet[j][k])
                            // 如果k不是最后一个，直接跳过
                            if (k != SrcSet.K - 1) break;
                            else
                            {
                                // 组合的结果unit
                                List<int> unit = new List<int>();
                                // 组合生成候选项集的项
                                for (int g = 0; g < SrcSet.K + 1; ++g)
                                {
                                    if (g != SrcSet.K)
                                        unit.Add(SrcSet.freqSet.freqSet[i][g]);
                                    else
                                        unit.Add(SrcSet.freqSet.freqSet[j][g - 1]);
                                }
                                if (!SrcSet.IsInFreq(unit))
                                {
                                    freqSet.freqSet.Add(unit);
                                    freqSet.supCount.Add(0);
                                }
                            }
        }

        // 判断C的子项集里面是否含有this没有的项
        private bool IsInFreq(List<int> C)
        {
            for (int i = 0; i < C.Count; ++i)
            {
                // 求出C的子集
                List<int> sub = new List<int>();
                for (int j = 0; j < C.Count; ++j)
                    if (j != C.Count - i - 1) sub.Add(C[j]);
                // 如果有一个子集没有在this的频繁项集中出现，那C是不频繁的
                if (!HaveSet(freqSet.freqSet,sub)) { return true; }
            }
            return false;
        }

        // 判断a里面有没有b
        private bool HaveSet(List<List<int>> a, List<int> b)
        {
            // 对于a的每一项
            for (int i = 0; i < a.Count; ++i)
            {
                int cnt = 0;
                // 判断b集里的每一个元素是否在目标项内出现过
                for (int j = 0; j < b.Count; ++j)
                    if (a[i].Contains(b[j])) cnt += 1;
                // 如果有一个a的项内，b的元素全都出现过，那确实a的项有b
                if (cnt == b.Count) return true;
            }
            return false;
        }

        // 判断a项有没有b的所有元素
        private bool ContainSet(List<int> a, List<int> b)
        {
            int cnt = 0;
            for (int j = 0; j < b.Count; ++j)
                if (a.Contains(b[j])) cnt += 1;
            if (cnt == b.Count) return true;
            else return false;
        }
    }
}
