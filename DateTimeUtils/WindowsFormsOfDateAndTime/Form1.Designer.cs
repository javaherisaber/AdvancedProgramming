namespace WindowsFormsOfDateAndTime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DokmeAfzodan = new System.Windows.Forms.Button();
            this.DokmeEslah = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MeghdartextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VahedcomboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NamayeshKamel_radioButton = new System.Windows.Forms.RadioButton();
            this.NamyeshKotah_radioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ZamaneJari = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(289, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب پیاده سازی";
            // 
            // radioButton2
            // 
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(256, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(107, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "پیاده سازی دوم";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(259, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "پیاده سازی اول";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.DokmeAfzodan);
            this.panel2.Controls.Add(this.DokmeEslah);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.MeghdartextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.VahedcomboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 119);
            this.panel2.TabIndex = 1;
            // 
            // DokmeAfzodan
            // 
            this.DokmeAfzodan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DokmeAfzodan.Location = new System.Drawing.Point(91, 72);
            this.DokmeAfzodan.Name = "DokmeAfzodan";
            this.DokmeAfzodan.Size = new System.Drawing.Size(60, 22);
            this.DokmeAfzodan.TabIndex = 6;
            this.DokmeAfzodan.Text = "افزودن";
            this.DokmeAfzodan.UseVisualStyleBackColor = true;
            this.DokmeAfzodan.Click += new System.EventHandler(this.DokmeAfzodan_Click);
            // 
            // DokmeEslah
            // 
            this.DokmeEslah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DokmeEslah.Location = new System.Drawing.Point(151, 72);
            this.DokmeEslah.Name = "DokmeEslah";
            this.DokmeEslah.Size = new System.Drawing.Size(61, 22);
            this.DokmeEslah.TabIndex = 5;
            this.DokmeEslah.Text = "کاستن";
            this.DokmeEslah.UseVisualStyleBackColor = true;
            this.DokmeEslah.Click += new System.EventHandler(this.DokmeEslah_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(218, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "مقدار";
            // 
            // MeghdartextBox
            // 
            this.MeghdartextBox.Location = new System.Drawing.Point(91, 46);
            this.MeghdartextBox.Name = "MeghdartextBox";
            this.MeghdartextBox.Size = new System.Drawing.Size(121, 20);
            this.MeghdartextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(218, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "نوع واحد";
            // 
            // VahedcomboBox1
            // 
            this.VahedcomboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VahedcomboBox1.FormattingEnabled = true;
            this.VahedcomboBox1.Items.AddRange(new object[] {
            "ثانیه",
            "دقیقه",
            "ساعت",
            "روز",
            "ماه",
            "سال"});
            this.VahedcomboBox1.Location = new System.Drawing.Point(91, 19);
            this.VahedcomboBox1.Name = "VahedcomboBox1";
            this.VahedcomboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.VahedcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.VahedcomboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(288, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "ویرایش زمان";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NamayeshKamel_radioButton);
            this.panel3.Controls.Add(this.NamyeshKotah_radioButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Location = new System.Drawing.Point(13, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 106);
            this.panel3.TabIndex = 2;
            // 
            // NamayeshKamel_radioButton
            // 
            this.NamayeshKamel_radioButton.AutoSize = true;
            this.NamayeshKamel_radioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NamayeshKamel_radioButton.Location = new System.Drawing.Point(141, 64);
            this.NamayeshKamel_radioButton.Name = "NamayeshKamel_radioButton";
            this.NamayeshKamel_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NamayeshKamel_radioButton.Size = new System.Drawing.Size(223, 17);
            this.NamayeshKamel_radioButton.TabIndex = 2;
            this.NamayeshKamel_radioButton.TabStop = true;
            this.NamayeshKamel_radioButton.Text = "نمايش کامل :        5:40 عصر 13 اسفند 1392";
            this.NamayeshKamel_radioButton.UseVisualStyleBackColor = true;
            this.NamayeshKamel_radioButton.CheckedChanged += new System.EventHandler(this.NamayeshKamel_radioButton_CheckedChanged);
            // 
            // NamyeshKotah_radioButton
            // 
            this.NamyeshKotah_radioButton.AutoSize = true;
            this.NamyeshKotah_radioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NamyeshKotah_radioButton.Location = new System.Drawing.Point(162, 41);
            this.NamyeshKotah_radioButton.Name = "NamyeshKotah_radioButton";
            this.NamyeshKotah_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NamyeshKotah_radioButton.Size = new System.Drawing.Size(202, 17);
            this.NamyeshKotah_radioButton.TabIndex = 1;
            this.NamyeshKotah_radioButton.TabStop = true;
            this.NamyeshKotah_radioButton.Text = "نمايش کوتاه :         17:40 13/12/1392";
            this.NamyeshKotah_radioButton.UseVisualStyleBackColor = true;
            this.NamyeshKotah_radioButton.CheckedChanged += new System.EventHandler(this.NamyeshKotah_radioButton_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(292, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "فرمت نمایش";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(277, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = ": تاریخ و زمان ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZamaneJari
            // 
            this.ZamaneJari.Cursor = System.Windows.Forms.Cursors.No;
            this.ZamaneJari.Location = new System.Drawing.Point(134, 395);
            this.ZamaneJari.Name = "ZamaneJari";
            this.ZamaneJari.ReadOnly = true;
            this.ZamaneJari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ZamaneJari.Size = new System.Drawing.Size(142, 20);
            this.ZamaneJari.TabIndex = 4;
            this.ZamaneJari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsOfDateAndTime.Properties.Resources.Wallpaper__401_;
            this.ClientSize = new System.Drawing.Size(421, 463);
            this.Controls.Add(this.ZamaneJari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "مدیریت تاریخ و زمان";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VahedcomboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MeghdartextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DokmeEslah;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton NamayeshKamel_radioButton;
        private System.Windows.Forms.RadioButton NamyeshKotah_radioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ZamaneJari;
        private System.Windows.Forms.Button DokmeAfzodan;
    }
}

