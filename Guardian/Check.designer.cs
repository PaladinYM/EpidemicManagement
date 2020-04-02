namespace Guardian
{
    partial class Check
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
            this.CityCbBox = new System.Windows.Forms.ComboBox();
            this.TempertureCbBox = new System.Windows.Forms.ComboBox();
            this.IsSuspectedCBBox = new System.Windows.Forms.ComboBox();
            this.IsconfirmedCBBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProvinceCbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CityCbBox
            // 
            this.CityCbBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CityCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityCbBox.FormattingEnabled = true;
            this.CityCbBox.Location = new System.Drawing.Point(210, 148);
            this.CityCbBox.Name = "CityCbBox";
            this.CityCbBox.Size = new System.Drawing.Size(121, 23);
            this.CityCbBox.TabIndex = 0;
            // 
            // TempertureCbBox
            // 
            this.TempertureCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TempertureCbBox.FormattingEnabled = true;
            this.TempertureCbBox.Items.AddRange(new object[] {
            "36.5~37.4°C",
            "37.5~38.5℃",
            "38.5℃以上"});
            this.TempertureCbBox.Location = new System.Drawing.Point(210, 201);
            this.TempertureCbBox.Name = "TempertureCbBox";
            this.TempertureCbBox.Size = new System.Drawing.Size(121, 23);
            this.TempertureCbBox.TabIndex = 1;
            // 
            // IsSuspectedCBBox
            // 
            this.IsSuspectedCBBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsSuspectedCBBox.FormattingEnabled = true;
            this.IsSuspectedCBBox.Items.AddRange(new object[] {
            "否",
            "是"});
            this.IsSuspectedCBBox.Location = new System.Drawing.Point(210, 256);
            this.IsSuspectedCBBox.Name = "IsSuspectedCBBox";
            this.IsSuspectedCBBox.Size = new System.Drawing.Size(121, 23);
            this.IsSuspectedCBBox.TabIndex = 2;
            this.IsSuspectedCBBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // IsconfirmedCBBox
            // 
            this.IsconfirmedCBBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IsconfirmedCBBox.FormattingEnabled = true;
            this.IsconfirmedCBBox.Items.AddRange(new object[] {
            "否",
            "是"});
            this.IsconfirmedCBBox.Location = new System.Drawing.Point(210, 308);
            this.IsconfirmedCBBox.Name = "IsconfirmedCBBox";
            this.IsconfirmedCBBox.Size = new System.Drawing.Size(121, 23);
            this.IsconfirmedCBBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "城市";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProvinceCbBox
            // 
            this.ProvinceCbBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProvinceCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProvinceCbBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ProvinceCbBox.FormattingEnabled = true;
            this.ProvinceCbBox.Location = new System.Drawing.Point(210, 99);
            this.ProvinceCbBox.Name = "ProvinceCbBox";
            this.ProvinceCbBox.Size = new System.Drawing.Size(121, 23);
            this.ProvinceCbBox.TabIndex = 5;
            this.ProvinceCbBox.SelectedIndexChanged += new System.EventHandler(this.ProvinceCbBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "省份";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "体温";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "是否隔离";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "是否确诊";
            // 
            // checkbtn
            // 
            this.checkbtn.Location = new System.Drawing.Point(64, 378);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(138, 33);
            this.checkbtn.TabIndex = 10;
            this.checkbtn.Text = "提交";
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "This is date.";
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(234, 378);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(138, 33);
            this.btnHistory.TabIndex = 12;
            this.btnHistory.Text = "历史打卡记录";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProvinceCbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsconfirmedCBBox);
            this.Controls.Add(this.IsSuspectedCBBox);
            this.Controls.Add(this.TempertureCbBox);
            this.Controls.Add(this.CityCbBox);
            this.Name = "Check";
            this.Text = "打卡";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Check_Closing);
            this.Load += new System.EventHandler(this.Check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CityCbBox;
        private System.Windows.Forms.ComboBox TempertureCbBox;
        private System.Windows.Forms.ComboBox IsSuspectedCBBox;
        private System.Windows.Forms.ComboBox IsconfirmedCBBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProvinceCbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHistory;
    }
}

