using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeesWithWindows
{
    public partial class DarjKarKard : Form
    {
        database DB = new database();
        private int hourindex,constindex;
        public DarjKarKard()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            hourindex = DB.Search_in_DB(1, textBox1.Text, textBox2.Text);
            if (hourindex!=-1)
            {
                    pictureBox9.Visible = false;
                    label15.Visible = true;
                    label16.Visible = true;
                    label18.Text = database.hourbase[hourindex].Codemelli;
                    label18.Visible = true;
                    textBox5.Visible = true;
                    button1.Visible = true;
            }
            else
            {
                MessageBox.Show("کارمند مورد نظر یافت نشد");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox5.Text.Length != 0)
            {
                try
                {
                    database.hourbase[hourindex].Amount_Of_Work = Convert.ToInt32(textBox5.Text);
                    MessageBox.Show("عملیات با موفقیت انجام شد");
                    textBox1.Clear();
                    textBox2.Clear();
                    pictureBox9.Visible = true;
                    label15.Visible = false;
                    label16.Visible = false;
                    label18.Visible = false;
                    textBox5.Visible = false;
                    textBox5.Clear();
                    button1.Visible = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("برای کارکرد مقدار عددی را وارد کنید");
                }
            }
            else
            {
                MessageBox.Show("مقدار کارکرد را وارد نمایید");
            }

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            constindex = DB.Search_in_DB(2, textBox6.Text, textBox4.Text);
            if (constindex!=-1)
            {
                    pictureBox5.Visible = false;
                    label6.Visible = true;
                    label11.Visible = true;
                    label4.Text = database.constbase[constindex].Codemelli;
                    label4.Visible = true;
                    textBox3.Visible = true;
                    button2.Visible = true;
            }
            else
            {
                MessageBox.Show("کارمند مورد نظر یافت نشد");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0)
            {
                try
                {
                    database.constbase[constindex].Amount_Of_Work=Convert.ToInt32(textBox3.Text);
                    MessageBox.Show("عملیات با موفقیت انجام شد");
                    textBox4.Clear();
                    textBox6.Clear();
                    pictureBox5.Visible = true;
                    label4.Visible = false;
                    label6.Visible = false;
                    label11.Visible = false;
                    textBox3.Visible = false;
                    textBox3.Clear();
                    button2.Visible = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("برای کارکرد مقدار عددی را وارد کنید");
                }
            }
            else
            {
                MessageBox.Show("مقدار کارکرد را وارد نمایید");
            }
            
        }


    }
}
