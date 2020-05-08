using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Commerce
{
    public partial class ShowPic : Form
    {
        string picPath = "";
        List<int> ids = new List<int>();
        List<string> picInfo = new List<string>();
        int currentIndex = 0;
        public ShowPic(string picPath, List<int> a, List<string> picInfo)
        {
            this.picPath = picPath;
            this.picInfo = picInfo;
            ids = a;
            InitializeComponent();
        }
        // 下一个图片
        private void pictureBox1_DoubleClick_1(object sender, EventArgs e)
        {
            if (currentIndex < ids.Count - 1) 
            {
                currentIndex += 1;
                pictureBox1.Image = Image.FromFile(picPath + "pic\\" + (ids[currentIndex] % 5).ToString() + @".jpg");
                piclabel.Text = picInfo[currentIndex];
            }
            else
            {
                this.Dispose();
            }
        }

        private void ShowPic_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(picPath + "pic\\" + (ids[0] % 5).ToString() + @".jpg");
            piclabel.Text = picInfo[0];
        }
    }
}
