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
    public partial class ListHoghoghPardakhti : Form
    {
        public ListHoghoghPardakhti()
        {
            InitializeComponent();
        }

        private void ListHoghoghPardakhti_Load(object sender, EventArgs e)
        {
            database DB = new database();
            DB.SortDataBase();
            string[] list = new string[database.hourbase_indexer + database.constbase_indexer];
            for (int i = 0; i < (database.hourbase_indexer+database.constbase_indexer); i++)
            {
                if (database.sorted_workers_indexes[i, 1] == 1)
                {
                    list[i] = (i + 1) + "_" + database.hourbase[database.sorted_workers_indexes[i, 0]].Lname + "           " + database.hourbase[database.sorted_workers_indexes[i, 0]].Fname + "           " + "کارمند ساعتی" + "           " + Convert.ToString(database.hourbase[database.sorted_workers_indexes[i, 0]].Salary) + "           " + Convert.ToString(database.hourbase[database.sorted_workers_indexes[i, 0]].Maliiyat);
                }
                else
                {
                    list[i] = (i + 1) + "_" + database.constbase[database.sorted_workers_indexes[i, 0]].Lname + "           " + database.constbase[database.sorted_workers_indexes[i, 0]].Fname + "           " + "کارمند حقوق ثابت" + "           " + Convert.ToString(database.constbase[database.sorted_workers_indexes[i, 0]].Salary) + "           " + Convert.ToString(database.constbase[database.sorted_workers_indexes[i, 0]].Maliiyat);
                }
            }
            richTextBox1.Lines = list;
        }

    }
}
