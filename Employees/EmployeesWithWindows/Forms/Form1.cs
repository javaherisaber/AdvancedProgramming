using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace EmployeesWithWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DarjSaati Saati = new DarjSaati();
            Saati.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DarjSabet Sabet = new DarjSabet();
            Sabet.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DarjKarKard darjkar = new DarjKarKard();
            darjkar.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search sh = new Search();
            sh.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListHoghoghPardakhti st = new ListHoghoghPardakhti();
            st.Show();
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("fa-IR"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                this.Opacity -= 0.1;
                System.Threading.Thread.Sleep(50);
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string output = "نام خانوادگی" + "           " + "نام" + "           " + "نوع کارمند" + "           "+"حقوق پرداختی";
                output += '\n';
                database DB = new database();
                DB.SortDataBase();
                for (int i = 0; i < (database.constbase_indexer+database.hourbase_indexer); i++)
                {
                    if (database.sorted_workers_indexes[i, 1] == 1)
                    {
                        output += ((i + 1) + "_" + database.hourbase[database.sorted_workers_indexes[i, 0]].Lname + "           " + database.hourbase[database.sorted_workers_indexes[i, 0]].Fname + "           " + "کارمند ساعتی" + "           " + Convert.ToString(database.hourbase[database.sorted_workers_indexes[i, 0]].Salary));
                        output += '\n';
                    }
                    else
                    {
                        output += ((i + 1) + "_" + database.constbase[database.sorted_workers_indexes[i, 0]].Lname + "           " + database.constbase[database.sorted_workers_indexes[i, 0]].Fname + "           " + "کارمند حقوق ثابت" + "           " + Convert.ToString(database.constbase[database.sorted_workers_indexes[i, 0]].Salary));
                        output += '\n';
                    }
                }
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(output);
                writer.Close();
                MessageBox.Show("ذخیره ی فایل موفقیت آمیز بود");
                SaveHelp sv = new SaveHelp();
                sv.Show();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SaveHelp sv = new SaveHelp();
            sv.Show();
        }

        private void saveFileHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveHelp sv = new SaveHelp();
            sv.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool status = true;
                try
                {
                    string Directory = openFileDialog1.FileName;
                    string[] st = new string[2000];
                    st = File.ReadAllLines(Directory);
                    for (int i = 0; i < st.Length; i++)
                    {
                        string[] subst = new string[5];
                        subst = st[i].Split('*');
                        if (subst.Length == 4)
                        {
                            database DB = new database();
                            if (DB.Search_in_DB(1, subst[0], subst[1]) == -1)
                            {
                                DB.HourDB_Creator(subst[0], subst[1], string.Empty, string.Empty, string.Empty, string.Empty, Convert.ToUInt32(subst[3]), string.Empty);
                            }
                            else
                            {
                                MessageBox.Show("برخی از اسامی از قبل در دیتابیس موجود می باشد آنها را اصلاح کرده و دوباره امتحان کنید");
                                status = false;
                                break;
                            }
                        }
                        if (subst.Length == 5)
                        {
                            database DB = new database();
                            if (DB.Search_in_DB(2, subst[0], subst[1]) == -1)
                            {
                                DB.ConstDB_Creator(subst[0], subst[1], string.Empty, string.Empty, string.Empty, string.Empty, Convert.ToUInt32(subst[3]), string.Empty, Convert.ToInt32(subst[4]));
                            }
                            else
                            {
                                MessageBox.Show("برخی از اسامی از قبل در دیتابیس موجود می باشد آنها را اصلاح کرده و دوباره امتحان کنید");
                                status = false;
                                break;
                            }
                        }
                        if (subst.Length != 4 && subst.Length != 5)
                        {
                            MessageBox.Show("متن داخل فایل فرمت مناسبی جهت ذخیره سازی در دیتابیس ندارد");
                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("متن داخل فایل فرمت مناسبی جهت ذخیره سازی در دیتابیس ندارد");
                }

                if (status)
                {
                    MessageBox.Show("ورود فایل با موفقیت انجام شد");
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OpenHelp oh = new OpenHelp();
            oh.Show();
        }

        private void openFileHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenHelp oh = new OpenHelp();
            oh.Show();
        }







    }
}
