using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsOfDateAndTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        implementation_1 time1 = new implementation_1();
        implementation_2 time2 = new implementation_2();
       private void NamyeshKotah_radioButton_CheckedChanged(object sender, EventArgs e)
       {
           if (radioButton1.Checked)
           {
               ZamaneJari.Text = time1.ShowTime(1);
           }
           if (radioButton2.Checked)
           {
               ZamaneJari.Text = time2.ShowTime(1);
           }
         
       }

       private void NamayeshKamel_radioButton_CheckedChanged(object sender, EventArgs e)
       {
           if (radioButton1.Checked)
           {
               ZamaneJari.Text = time1.ShowTime(2);
           }
           if (radioButton2.Checked)
           {
               ZamaneJari.Text = time2.ShowTime(2);
           }


       }

       private void DokmeEslah_Click(object sender, EventArgs e)
       {
           try
           {
     string select;
           select =(string) VahedcomboBox1.SelectedItem;
           if (radioButton1.Checked)
           {
               if (MeghdartextBox.TextLength != 0)
               {
                   switch (select)
                   {
                       case "ثانیه":
                           time1.TurnDown(6, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "دقیقه":
                           time1.TurnDown(5, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ساعت":
                           time1.TurnDown(4, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "روز":
                           time1.TurnDown(3, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ماه":
                           time1.TurnDown(2, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "سال":
                           time1.TurnDown(1, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                   }
                   if (NamyeshKotah_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time1.ShowTime(1));
                   }
                   if (NamayeshKamel_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time1.ShowTime(2));
                   }
               }
           }
           if (radioButton2.Checked)
           {
               if (MeghdartextBox.TextLength != 0)
               {
                   switch (select)
                   {
                       case "ثانیه":
                           time2.TurnDown(6, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "دقیقه":
                           time2.TurnDown(5, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ساعت":
                           time2.TurnDown(4, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "روز":
                           time2.TurnDown(3, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ماه":
                           time2.TurnDown(2, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "سال":
                           time2.TurnDown(1, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                   }
                   if (NamyeshKotah_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time2.ShowTime(1));
                   }
                   if (NamayeshKamel_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time2.ShowTime(2));
                   }
               }
           }
           }
           catch (Exception)
           {
               MessageBox.Show("فرمت متن وارد شده صحیح نمی باشد");
               
           }
           
       }

       private void DokmeAfzodan_Click(object sender, EventArgs e)
       {
           try
           {
string select;
           select = (string)VahedcomboBox1.SelectedItem;
           if (radioButton1.Checked)
           {
               if (MeghdartextBox.TextLength != 0)
               {
                   switch (select)
                   {
                       case "ثانیه":
                           time1.Add(6, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "دقیقه":
                           time1.Add(5, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ساعت":
                           time1.Add(4, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "روز":
                           time1.Add(3, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ماه":
                           time1.Add(2, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "سال":
                           time1.Add(1, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                   }
                   if (NamyeshKotah_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time1.ShowTime(1));
                   }
                   if (NamayeshKamel_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time1.ShowTime(2));
                   }
               }
           }
           if (radioButton2.Checked)
           {
               if (MeghdartextBox.TextLength != 0)
               {
                   switch (select)
                   {
                       case "ثانیه":
                           time2.Add(6, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "دقیقه":
                           time2.Add(5, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ساعت":
                           time2.Add(4, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "روز":
                           time2.Add(3, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "ماه":
                           time2.Add(2, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                       case "سال":
                           time2.Add(1, Convert.ToInt32(MeghdartextBox.Text));
                           break;
                   }
                   if (NamyeshKotah_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time2.ShowTime(1));
                   }
                   if (NamayeshKamel_radioButton.Checked)
                   {
                       ZamaneJari.Text = Convert.ToString(time2.ShowTime(2));
                   }
               }
           }
           }
           catch (Exception)
           {

               MessageBox.Show("فرمت متن وارد شده صحیح نمی باشد");         
           }
           
       }

       private void radioButton1_CheckedChanged(object sender, EventArgs e)
       {
           if (NamyeshKotah_radioButton.Checked&&radioButton1.Checked)
           {
               ZamaneJari.Text = Convert.ToString(time1.ShowTime(1));
           }
           if (NamayeshKamel_radioButton.Checked&&radioButton1.Checked)
           {
               ZamaneJari.Text = Convert.ToString(time1.ShowTime(2));
           }
       }

       private void radioButton2_CheckedChanged(object sender, EventArgs e)
       {
           if (NamyeshKotah_radioButton.Checked&&radioButton2.Checked)
           {
               ZamaneJari.Text = Convert.ToString(time1.ShowTime(1));
           }
           if (NamayeshKamel_radioButton.Checked&&radioButton2.Checked)
           {
               ZamaneJari.Text = Convert.ToString(time1.ShowTime(2));
           }
       }
       


    }
}
