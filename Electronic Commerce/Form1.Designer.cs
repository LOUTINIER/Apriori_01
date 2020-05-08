namespace Electronic_Commerce
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox = new System.Windows.Forms.TextBox();
            this.minuid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxuid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maxpid = new System.Windows.Forms.TextBox();
            this.minpid = new System.Windows.Forms.TextBox();
            this.ReadDataBtn = new System.Windows.Forms.Button();
            this.minsup = new System.Windows.Forms.TextBox();
            this.IntRecBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfRecBtn = new System.Windows.Forms.Button();
            this.recnum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minint = new System.Windows.Forms.TextBox();
            this.minconf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gen2FreqBtn = new System.Windows.Forms.Button();
            this.ShowRuleBtn = new System.Windows.Forms.Button();
            this.ShowFreqBtn = new System.Windows.Forms.Button();
            this.GenFreqBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataAmount = new System.Windows.Forms.TextBox();
            this.GenDataBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(5, 3);
            this.textBox.MaxLength = 999999999;
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(1610, 937);
            this.textBox.TabIndex = 0;
            // 
            // minuid
            // 
            this.minuid.Location = new System.Drawing.Point(101, 19);
            this.minuid.Name = "minuid";
            this.minuid.Size = new System.Drawing.Size(82, 27);
            this.minuid.TabIndex = 0;
            this.minuid.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "生成uid范围";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxuid
            // 
            this.maxuid.Location = new System.Drawing.Point(189, 19);
            this.maxuid.Name = "maxuid";
            this.maxuid.Size = new System.Drawing.Size(82, 27);
            this.maxuid.TabIndex = 4;
            this.maxuid.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(0, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "生成pid范围";
            // 
            // maxpid
            // 
            this.maxpid.Location = new System.Drawing.Point(189, 50);
            this.maxpid.Name = "maxpid";
            this.maxpid.Size = new System.Drawing.Size(82, 27);
            this.maxpid.TabIndex = 6;
            this.maxpid.Text = "100";
            // 
            // minpid
            // 
            this.minpid.Location = new System.Drawing.Point(101, 50);
            this.minpid.Name = "minpid";
            this.minpid.Size = new System.Drawing.Size(82, 27);
            this.minpid.TabIndex = 7;
            this.minpid.Text = "0";
            // 
            // ReadDataBtn
            // 
            this.ReadDataBtn.Location = new System.Drawing.Point(4, 149);
            this.ReadDataBtn.Name = "ReadDataBtn";
            this.ReadDataBtn.Size = new System.Drawing.Size(264, 28);
            this.ReadDataBtn.TabIndex = 8;
            this.ReadDataBtn.Text = "读入数据";
            this.ReadDataBtn.UseVisualStyleBackColor = true;
            this.ReadDataBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // minsup
            // 
            this.minsup.Location = new System.Drawing.Point(101, 183);
            this.minsup.Name = "minsup";
            this.minsup.Size = new System.Drawing.Size(82, 27);
            this.minsup.TabIndex = 9;
            this.minsup.Text = "5";
            this.minsup.TextChanged += new System.EventHandler(this.minsup_TextChanged);
            // 
            // IntRecBtn
            // 
            this.IntRecBtn.Location = new System.Drawing.Point(4, 499);
            this.IntRecBtn.Name = "IntRecBtn";
            this.IntRecBtn.Size = new System.Drawing.Size(264, 28);
            this.IntRecBtn.TabIndex = 10;
            this.IntRecBtn.Text = "兴趣度推荐商品";
            this.IntRecBtn.UseVisualStyleBackColor = true;
            this.IntRecBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "最小支持度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(186, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "%";
            // 
            // ConfRecBtn
            // 
            this.ConfRecBtn.Location = new System.Drawing.Point(4, 533);
            this.ConfRecBtn.Name = "ConfRecBtn";
            this.ConfRecBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfRecBtn.Size = new System.Drawing.Size(264, 28);
            this.ConfRecBtn.TabIndex = 13;
            this.ConfRecBtn.Text = "置信度推荐商品";
            this.ConfRecBtn.UseVisualStyleBackColor = true;
            // 
            // recnum
            // 
            this.recnum.Location = new System.Drawing.Point(101, 467);
            this.recnum.Name = "recnum";
            this.recnum.Size = new System.Drawing.Size(82, 27);
            this.recnum.TabIndex = 14;
            this.recnum.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(0, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "推荐个数";
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(101, 436);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(82, 27);
            this.productid.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(0, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "当前商品uid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "兴趣度阈值";
            // 
            // minint
            // 
            this.minint.Location = new System.Drawing.Point(101, 316);
            this.minint.Name = "minint";
            this.minint.Size = new System.Drawing.Size(82, 27);
            this.minint.TabIndex = 19;
            this.minint.Text = "100";
            this.minint.TextChanged += new System.EventHandler(this.minint_TextChanged);
            // 
            // minconf
            // 
            this.minconf.Location = new System.Drawing.Point(101, 347);
            this.minconf.Name = "minconf";
            this.minconf.Size = new System.Drawing.Size(82, 27);
            this.minconf.TabIndex = 20;
            this.minconf.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(0, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "置信度阈值";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox);
            this.splitContainer1.Size = new System.Drawing.Size(1902, 943);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gen2FreqBtn);
            this.groupBox1.Controls.Add(this.ShowRuleBtn);
            this.groupBox1.Controls.Add(this.ShowFreqBtn);
            this.groupBox1.Controls.Add(this.GenFreqBtn);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.minint);
            this.groupBox1.Controls.Add(this.minconf);
            this.groupBox1.Controls.Add(this.minuid);
            this.groupBox1.Controls.Add(this.GenDataBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maxuid);
            this.groupBox1.Controls.Add(this.productid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maxpid);
            this.groupBox1.Controls.Add(this.recnum);
            this.groupBox1.Controls.Add(this.minpid);
            this.groupBox1.Controls.Add(this.ConfRecBtn);
            this.groupBox1.Controls.Add(this.ReadDataBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minsup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IntRecBtn);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 579);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作台";
            // 
            // Gen2FreqBtn
            // 
            this.Gen2FreqBtn.Location = new System.Drawing.Point(5, 216);
            this.Gen2FreqBtn.Name = "Gen2FreqBtn";
            this.Gen2FreqBtn.Size = new System.Drawing.Size(264, 28);
            this.Gen2FreqBtn.TabIndex = 31;
            this.Gen2FreqBtn.Text = "生成到频繁2项集";
            this.Gen2FreqBtn.UseVisualStyleBackColor = true;
            this.Gen2FreqBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // ShowRuleBtn
            // 
            this.ShowRuleBtn.Location = new System.Drawing.Point(4, 400);
            this.ShowRuleBtn.Name = "ShowRuleBtn";
            this.ShowRuleBtn.Size = new System.Drawing.Size(264, 28);
            this.ShowRuleBtn.TabIndex = 30;
            this.ShowRuleBtn.Text = "生成并展示关联规则";
            this.ShowRuleBtn.UseVisualStyleBackColor = true;
            this.ShowRuleBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // ShowFreqBtn
            // 
            this.ShowFreqBtn.Location = new System.Drawing.Point(5, 284);
            this.ShowFreqBtn.Name = "ShowFreqBtn";
            this.ShowFreqBtn.Size = new System.Drawing.Size(264, 28);
            this.ShowFreqBtn.TabIndex = 29;
            this.ShowFreqBtn.Text = "展示频繁项集";
            this.ShowFreqBtn.UseVisualStyleBackColor = true;
            this.ShowFreqBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // GenFreqBtn
            // 
            this.GenFreqBtn.Location = new System.Drawing.Point(5, 250);
            this.GenFreqBtn.Name = "GenFreqBtn";
            this.GenFreqBtn.Size = new System.Drawing.Size(264, 28);
            this.GenFreqBtn.TabIndex = 28;
            this.GenFreqBtn.Text = "生成所有频繁项集";
            this.GenFreqBtn.UseVisualStyleBackColor = true;
            this.GenFreqBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(1, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "（阈值为空则按大小顺序推荐）";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(186, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(186, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(247, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "个";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "生成数据量";
            // 
            // dataAmount
            // 
            this.dataAmount.Location = new System.Drawing.Point(101, 82);
            this.dataAmount.Name = "dataAmount";
            this.dataAmount.Size = new System.Drawing.Size(140, 27);
            this.dataAmount.TabIndex = 22;
            this.dataAmount.Text = "2000";
            // 
            // GenDataBtn
            // 
            this.GenDataBtn.Location = new System.Drawing.Point(4, 115);
            this.GenDataBtn.Name = "GenDataBtn";
            this.GenDataBtn.Size = new System.Drawing.Size(264, 28);
            this.GenDataBtn.TabIndex = 1;
            this.GenDataBtn.Text = "生成数据";
            this.GenDataBtn.UseVisualStyleBackColor = true;
            this.GenDataBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 943);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 990);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox minuid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxuid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxpid;
        private System.Windows.Forms.TextBox minpid;
        private System.Windows.Forms.Button ReadDataBtn;
        private System.Windows.Forms.TextBox minsup;
        private System.Windows.Forms.Button IntRecBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ConfRecBtn;
        private System.Windows.Forms.TextBox recnum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minint;
        private System.Windows.Forms.TextBox minconf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dataAmount;
        private System.Windows.Forms.Button GenFreqBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ShowRuleBtn;
        private System.Windows.Forms.Button ShowFreqBtn;
        private System.Windows.Forms.Button GenDataBtn;
        private System.Windows.Forms.Button Gen2FreqBtn;
    }
}

