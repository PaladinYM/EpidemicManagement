namespace Guardian
{
    partial class QuestionAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionAnswer));
            this.btnNxt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLst = new System.Windows.Forms.Button();
            this.optBtn4 = new System.Windows.Forms.RadioButton();
            this.txtQues = new System.Windows.Forms.TextBox();
            this.optBtn3 = new System.Windows.Forms.RadioButton();
            this.optBtn1 = new System.Windows.Forms.RadioButton();
            this.optBtn2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNxt
            // 
            this.btnNxt.Location = new System.Drawing.Point(249, 297);
            this.btnNxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(129, 31);
            this.btnNxt.TabIndex = 6;
            this.btnNxt.Text = "下一题";
            this.btnNxt.UseVisualStyleBackColor = true;
            this.btnNxt.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 377);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnNxt);
            this.splitContainer1.Panel2.Controls.Add(this.btnLst);
            this.splitContainer1.Panel2.Controls.Add(this.optBtn4);
            this.splitContainer1.Panel2.Controls.Add(this.txtQues);
            this.splitContainer1.Panel2.Controls.Add(this.optBtn3);
            this.splitContainer1.Panel2.Controls.Add(this.optBtn1);
            this.splitContainer1.Panel2.Controls.Add(this.optBtn2);
            this.splitContainer1.Size = new System.Drawing.Size(780, 377);
            this.splitContainer1.SplitterDistance = 342;
            this.splitContainer1.TabIndex = 9;
            // 
            // btnLst
            // 
            this.btnLst.Location = new System.Drawing.Point(64, 297);
            this.btnLst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(129, 31);
            this.btnLst.TabIndex = 5;
            this.btnLst.Text = "上一题";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // optBtn4
            // 
            this.optBtn4.AutoSize = true;
            this.optBtn4.Location = new System.Drawing.Point(21, 107);
            this.optBtn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optBtn4.Name = "optBtn4";
            this.optBtn4.Size = new System.Drawing.Size(84, 19);
            this.optBtn4.TabIndex = 4;
            this.optBtn4.TabStop = true;
            this.optBtn4.Text = "OVID-19";
            this.optBtn4.UseVisualStyleBackColor = true;
            this.optBtn4.CheckedChanged += new System.EventHandler(this.optBtn4_CheckedChanged);
            // 
            // txtQues
            // 
            this.txtQues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQues.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQues.Location = new System.Drawing.Point(0, 0);
            this.txtQues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQues.Multiline = true;
            this.txtQues.Name = "txtQues";
            this.txtQues.ReadOnly = true;
            this.txtQues.Size = new System.Drawing.Size(434, 53);
            this.txtQues.TabIndex = 7;
            this.txtQues.Text = "新冠状病毒的学术名称为";
            // 
            // optBtn3
            // 
            this.optBtn3.AutoSize = true;
            this.optBtn3.Checked = true;
            this.optBtn3.Location = new System.Drawing.Point(21, 71);
            this.optBtn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optBtn3.Name = "optBtn3";
            this.optBtn3.Size = new System.Drawing.Size(84, 19);
            this.optBtn3.TabIndex = 3;
            this.optBtn3.TabStop = true;
            this.optBtn3.Text = "CIOV-19";
            this.optBtn3.UseVisualStyleBackColor = true;
            this.optBtn3.CheckedChanged += new System.EventHandler(this.optBtn3_CheckedChanged);
            // 
            // optBtn1
            // 
            this.optBtn1.AutoSize = true;
            this.optBtn1.Location = new System.Drawing.Point(21, 179);
            this.optBtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optBtn1.Name = "optBtn1";
            this.optBtn1.Size = new System.Drawing.Size(92, 19);
            this.optBtn1.TabIndex = 1;
            this.optBtn1.TabStop = true;
            this.optBtn1.Text = "COVID-19";
            this.optBtn1.UseVisualStyleBackColor = true;
            this.optBtn1.CheckedChanged += new System.EventHandler(this.optBtn1_CheckedChanged);
            // 
            // optBtn2
            // 
            this.optBtn2.AutoSize = true;
            this.optBtn2.Location = new System.Drawing.Point(21, 144);
            this.optBtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optBtn2.Name = "optBtn2";
            this.optBtn2.Size = new System.Drawing.Size(84, 19);
            this.optBtn2.TabIndex = 2;
            this.optBtn2.TabStop = true;
            this.optBtn2.Text = "CVID-19";
            this.optBtn2.UseVisualStyleBackColor = true;
            this.optBtn2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // QuestionAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 377);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionAnswer";
            this.Text = "疫情小课堂";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QA_Closing);
            this.Load += new System.EventHandler(this.QA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton optBtn1;
        private System.Windows.Forms.RadioButton optBtn2;
        private System.Windows.Forms.RadioButton optBtn3;
        private System.Windows.Forms.RadioButton optBtn4;
        private System.Windows.Forms.TextBox txtQues;
        private System.Windows.Forms.Button btnLst;
    }
}

