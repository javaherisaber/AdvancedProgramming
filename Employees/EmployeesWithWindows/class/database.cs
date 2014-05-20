using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace EmployeesWithWindows
{
    class database
    {
        public static HourBaseWorkers[] hourbase = new HourBaseWorkers[1000];
        public static ConstBaseWorkers[] constbase = new ConstBaseWorkers[1000];
        public static int[,] sorted_workers_indexes = new int[2000,2];//column 0 is index of worker and column 1 is type of worker(1 for hourbase worker and 2 for constbase worker)
        public static int hourbase_indexer = 0;
        public static int constbase_indexer =0;
        /// <summary>
        /// این متد برای ایجاد یک کارمند ساعتی می باشد
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="fathname"></param>
        /// <param name="birdate"></param>
        /// <param name="birplace"></param>
        /// <param name="codemelli"></param>
        /// <param name="contractsalary"></param>
        /// <param name="address"></param>
        public void HourDB_Creator(string fname,string lname,string fathname,string birdate,string birplace,string codemelli,ulong contractsalary,string address)
        {
            hourbase[hourbase_indexer] = new HourBaseWorkers();
            database.hourbase[hourbase_indexer].Fname = fname;
            database.hourbase[hourbase_indexer].Lname = lname;
            database.hourbase[hourbase_indexer].Fathername = fathname;
            database.hourbase[hourbase_indexer].BirthdayDate = birdate;
            database.hourbase[hourbase_indexer].BirthdayPlace = birplace;
            database.hourbase[hourbase_indexer].Codemelli = codemelli;
            database.hourbase[hourbase_indexer].ContractSalary = contractsalary;
            database.hourbase[hourbase_indexer].Address = address;
            hourbase_indexer++;
        }
        /// <summary>
        /// این متد برای ایجاد یک کارمند حقوق ثابت می باشد
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="fathname"></param>
        /// <param name="birdate"></param>
        /// <param name="birplace"></param>
        /// <param name="codemelli"></param>
        /// <param name="contractsalary"></param>
        /// <param name="address"></param>
        /// <param name="determinedhour"></param>
        public void ConstDB_Creator(string fname, string lname, string fathname, string birdate, string birplace, string codemelli, ulong contractsalary, string address, int determinedhour)
        {
            constbase[constbase_indexer] = new ConstBaseWorkers();
            database.constbase[constbase_indexer].Fname = fname;
            database.constbase[constbase_indexer].Lname = lname;
            database.constbase[constbase_indexer].Fathername = fathname;
            database.constbase[constbase_indexer].BirthdayDate = birdate;
            database.constbase[constbase_indexer].BirthdayPlace = birplace;
            database.constbase[constbase_indexer].Codemelli = codemelli;
            database.constbase[constbase_indexer].ContractSalary = contractsalary;
            database.constbase[constbase_indexer].Address = address;
            database.constbase[constbase_indexer].DeterminedMonthWork = determinedhour;
            constbase_indexer++;
        }
        /// <summary>
        /// برای جستجو در ساعتی ایندکسر 1 و برای جستجوی حقوق ثابت ایندکسر 2 را وارد نمایید
        /// </summary>
        /// <param name="select"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public int Search_in_DB(int indexer,string fname,string lname)
        {
            if (indexer == 1)
            {
                    for (int i = 0; i < hourbase_indexer; i++)
                    {
                        if (hourbase[i].Fname == fname && hourbase[i].Lname == lname)
                        {
                            return i;
                        }
                    }
                
            }
            else
            {
                    for (int i = 0; i < constbase_indexer; i++)
                    {
                        if (constbase[i].Fname == fname && constbase[i].Lname == lname)
                        {
                            return i;
                        }
                    }
               
            }
            return -1;
        }
        /// <summary>
        /// این متد کلیه ی کارمندان را بر اساس نام خانوادگی مرتب می کند
        /// </summary>
        public void SortDataBase()
        {
            string[,] allWorkers = new string[2000, 3];//colunm 0 is Lname,colunm 1 is index,colunm 2 is type(1 for hourbase worker and 2 for constbaseworker)
            int allworkers_index = 0;
            for (int i = 0; i < hourbase_indexer; i++)
            {
                allWorkers[i, 0] = hourbase[i].Lname;
                allWorkers[i, 1] = Convert.ToString(i);
                allWorkers[i, 2] = "1";
                allworkers_index++;
            }
            for (int j = 0; j < constbase_indexer; j++)
            {
                allWorkers[allworkers_index , 0] = constbase[j].Lname;
                allWorkers[allworkers_index , 1] = Convert.ToString(j);
                allWorkers[allworkers_index , 2] = "2";
                allworkers_index++;
            }
            for (int len = allworkers_index-1; len>0; len--)
            {
                for (int i = 0; i < len; i++)
                {
                    int minlength = 0;
                    if (allWorkers[i, 0].Length > allWorkers[i + 1, 0].Length)
                    {
                        minlength = allWorkers[i + 1, 0].Length;
                    }
                    else
                    {
                        minlength = allWorkers[i, 0].Length;
                    }
                    bool flag1 = true, flag2 = true;//flag1 for control changing whole word and flag2 for control index changing
                    for (int j = 0; j < minlength; j++)
                    {
                        if (allWorkers[i, 0][j] > allWorkers[i + 1, 0][j] && flag2 == true)
                        {
                            string temp;
                            temp = allWorkers[i + 1, 0];
                            allWorkers[i + 1, 0] = allWorkers[i, 0];
                            allWorkers[i, 0] = temp;
                            temp = allWorkers[i + 1, 1];
                            allWorkers[i + 1, 1] = allWorkers[i, 1];
                            allWorkers[i, 1] = temp;
                            temp = allWorkers[i + 1, 2];
                            allWorkers[i + 1, 2] = allWorkers[i, 2];
                            allWorkers[i, 2] = temp;
                            flag1 = false;
                            flag2 = false;
                            break;
                        }
                        else if (allWorkers[i, 0][j] < allWorkers[i + 1, 0][j] && flag2 == true)
                        {
                            flag1 = false;
                            flag2 = false;
                            break;
                        }
                    }
                    if (flag1 == true && allWorkers[i,0].Length != allWorkers[i+1,0].Length)
                    {
                        if (allWorkers[i, 0].Length > allWorkers[i + 1, 0].Length)
                        {
                            string temp;
                            temp = allWorkers[i + 1, 0];
                            allWorkers[i + 1, 0] = allWorkers[i, 0];
                            allWorkers[i, 0] = temp;
                            temp = allWorkers[i + 1, 1];
                            allWorkers[i + 1, 1] = allWorkers[i, 1];
                            allWorkers[i, 1] = temp;
                            temp = allWorkers[i + 1, 2];
                            allWorkers[i + 1, 2] = allWorkers[i, 2];
                            allWorkers[i, 2] = temp;
                        }
                    }

                }
            }//bubble sort
            for (int i = 0; i < allworkers_index; i++)
            {
                sorted_workers_indexes[i, 0] =Convert.ToInt32(allWorkers[i, 1]);
                sorted_workers_indexes[i, 1] = Convert.ToInt32(allWorkers[i, 2]);
            }
        }
    }
}
