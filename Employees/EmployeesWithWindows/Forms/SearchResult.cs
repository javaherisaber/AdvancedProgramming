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
    public partial class SearchResult : Form
    {
        public int constindex;
        public int hourindex;
        public SearchResult()
        {
            InitializeComponent();
        }
        private void SearchResult_Load(object sender, EventArgs e)
        {
            if (constindex == -1 && hourindex != -1)
            {
                panel2.Visible = false;
                textBox1.Text = database.hourbase[hourindex].Fname;
                textBox2.Text = database.hourbase[hourindex].Lname;
                textBox3.Text = database.hourbase[hourindex].Fathername;
                textBox4.Text = database.hourbase[hourindex].BirthdayDate;
                textBox5.Text = database.hourbase[hourindex].BirthdayPlace;
                textBox6.Text = database.hourbase[hourindex].Codemelli;
                textBox7.Text = Convert.ToString(database.hourbase[hourindex].ContractSalary);
                textBox8.Text = database.hourbase[hourindex].Address;
            }
            if (hourindex == -1 && constindex != -1)
            {
                panel1.Visible = false;
                textBox16.Text = database.constbase[constindex].Fname;
                textBox15.Text = database.constbase[constindex].Lname;
                textBox14.Text = database.constbase[constindex].Fathername;
                textBox13.Text = database.constbase[constindex].BirthdayDate;
                textBox12.Text = database.constbase[constindex].BirthdayPlace;
                textBox11.Text = database.constbase[constindex].Codemelli;
                textBox10.Text = Convert.ToString(database.constbase[constindex].ContractSalary);
                textBox17.Text = Convert.ToString(database.constbase[constindex].DeterminedMonthWork);
                textBox9.Text = database.constbase[constindex].Address;
            }
            if (constindex != -1 && hourindex != -1)
            {
                textBox16.Text = database.constbase[constindex].Fname;
                textBox15.Text = database.constbase[constindex].Lname;
                textBox14.Text = database.constbase[constindex].Fathername;
                textBox13.Text = database.constbase[constindex].BirthdayDate;
                textBox12.Text = database.constbase[constindex].BirthdayPlace;
                textBox11.Text = database.constbase[constindex].Codemelli;
                textBox10.Text = Convert.ToString(database.constbase[constindex].ContractSalary);
                textBox17.Text = Convert.ToString(database.constbase[constindex].DeterminedMonthWork);
                textBox9.Text = database.constbase[constindex].Address;

                textBox1.Text = database.hourbase[hourindex].Fname;
                textBox2.Text = database.hourbase[hourindex].Lname;
                textBox3.Text = database.hourbase[hourindex].Fathername;
                textBox4.Text = database.hourbase[hourindex].BirthdayDate;
                textBox5.Text = database.hourbase[hourindex].BirthdayPlace;
                textBox6.Text = database.hourbase[hourindex].Codemelli;
                textBox7.Text = Convert.ToString(database.hourbase[hourindex].ContractSalary);
                textBox8.Text = database.hourbase[hourindex].Address;
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            database.constbase[constindex].Address = textBox9.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox9.ReadOnly = true;
            pictureBox34.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            pictureBox18.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            pictureBox19.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
            pictureBox20.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
            pictureBox21.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            pictureBox22.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
            pictureBox23.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
            pictureBox24.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox8.ReadOnly = false;
            pictureBox25.Visible = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            database.hourbase[hourindex].Fname = textBox1.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox1.ReadOnly = true;
            pictureBox18.Visible = false;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            database.hourbase[hourindex].Lname = textBox2.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox2.ReadOnly = true;
            pictureBox19.Visible = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            database.hourbase[hourindex].Fathername = textBox3.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox3.ReadOnly = true;
            pictureBox20.Visible = false;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            database.hourbase[hourindex].BirthdayDate = textBox4.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox4.ReadOnly = true;
            pictureBox21.Visible = false;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("محل تولد را انتخاب نمایید");
            }
            else
            {
                database.hourbase[hourindex].BirthdayPlace = comboBox1.Text;
                MessageBox.Show("تصحیح انجام شد");
                comboBox1.Visible = false;
                textBox5.Text = comboBox1.Text;
                pictureBox22.Visible = false;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            database.hourbase[hourindex].Codemelli = textBox6.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox6.ReadOnly = true;
            pictureBox23.Visible = false;

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            try
            {
                database.hourbase[hourindex].ContractSalary = Convert.ToUInt32(textBox7.Text);
                MessageBox.Show("تصحیح انجام شد");
                textBox7.ReadOnly = true;
                pictureBox24.Visible = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("مقدار عددی وارد نمایید");
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            database.hourbase[hourindex].Address = textBox8.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox8.ReadOnly = true;
            pictureBox25.Visible = false;
        }



        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox16.ReadOnly = false;
            pictureBox26.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox15.ReadOnly = false;
            pictureBox27.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox14.ReadOnly = false;
            pictureBox28.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textBox13.ReadOnly = false;
            pictureBox29.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            pictureBox30.Visible = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox11.ReadOnly = false;
            pictureBox31.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textBox10.ReadOnly = false;
            pictureBox32.Visible = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            textBox17.ReadOnly = false;
            pictureBox33.Visible = true;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textBox9.ReadOnly = false;
            pictureBox34.Visible = true;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            database.constbase[constindex].Fname = textBox16.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox16.ReadOnly = true;
            pictureBox26.Visible = false;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            database.constbase[constindex].Lname = textBox15.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox15.ReadOnly = true;
            pictureBox27.Visible = false;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            database.constbase[constindex].Fathername = textBox14.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox14.ReadOnly = true;
            pictureBox28.Visible = false;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            database.constbase[constindex].BirthdayDate = textBox13.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox13.ReadOnly = true;
            pictureBox29.Visible = false;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Length == 0)
            {
                MessageBox.Show("محل تولد را انتخاب کنید");
            }
            else
            {
                database.constbase[constindex].BirthdayPlace = comboBox2.Text;
                MessageBox.Show("تصحیح انجام شد");
                comboBox2.Visible = false;
                textBox12.Text = comboBox2.Text;
                pictureBox30.Visible = false;
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            database.constbase[constindex].Codemelli = textBox11.Text;
            MessageBox.Show("تصحیح انجام شد");
            textBox11.ReadOnly = true;
            pictureBox31.Visible = false;
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            try
            {
                database.constbase[constindex].ContractSalary = Convert.ToUInt32(textBox10.Text);
                MessageBox.Show("تصحیح انجام شد");
                textBox10.ReadOnly = true;
                pictureBox32.Visible = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("مقدار عددی وارد نمایید");
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            try
            {
                database.constbase[constindex].DeterminedMonthWork = Convert.ToInt32(textBox17.Text);
                MessageBox.Show("تصحیح انجام شد");
                textBox17.ReadOnly = true;
                pictureBox33.Visible = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("مقدار عددی وارد نمایید");
            }
        }






    }
}
