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
    public partial class Search : Form
    {
        public int constindex;
        public int hourindex;
        database DB = new database();
        public Search()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            constindex = DB.Search_in_DB(2, textBox1.Text, textBox2.Text);
            hourindex = DB.Search_in_DB(1, textBox1.Text, textBox2.Text);
            if (constindex == -1 && hourindex == -1)
            {
                MessageBox.Show("هیچ کارمندی با این مشخصات یافت نشد");
            }
            else
            {
                SearchResult shr = new SearchResult();
                shr.constindex = constindex;
                shr.hourindex = hourindex;
                shr.Show();
            }
        }


    }
}
