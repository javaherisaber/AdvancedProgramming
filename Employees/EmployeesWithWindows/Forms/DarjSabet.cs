using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace EmployeesWithWindows
{
    public partial class DarjSabet : Form
    {
        public DarjSabet()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            bool f = int.TryParse(textBox1.Text, out a);
            if (!f)
            {
                MessageBox.Show("لطفا مقدار عددی وارد نمایید");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int a = 0;
            bool f = int.TryParse(textBox2.Text, out a);
            if (!f)
            {
                MessageBox.Show("لطفا مقدار عددی وارد نمایید");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0 || textBox7.Text.Length == 0 || textBox2.Text.Length == 0||textBox1.Text.Length == 0)
            {
                MessageBox.Show("لطفا تمامی فیلد های اجباری را وارد نمایید");
            }
            else
            {
                try
                {
                    database DB = new database();
                    if (DB.Search_in_DB(2,textBox8.Text,textBox7.Text)!=-1)
                    {
                        MessageBox.Show("کارمندی با این نام و نام خانوادگی از قبل وجود دارد لطفا دوباره امتحان کنید"); 
                    }
                    else
                    {
                        DB.ConstDB_Creator(this.textBox8.Text, this.textBox7.Text, this.textBox6.Text, this.textBox5.Text, this.comboBox1.Text, this.textBox4.Text, Convert.ToUInt32(this.textBox2.Text), this.textBox3.Text, Convert.ToInt32(textBox1.Text));
                        MessageBox.Show("عملیات با موفقیت انجام شد");
                        this.Close();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("مقادیر عددی را به درستی وارد نمایید");
                }
            }
        }
        

    }
}
