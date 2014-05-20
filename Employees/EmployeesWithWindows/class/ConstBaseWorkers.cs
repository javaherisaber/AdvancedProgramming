using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeesWithWindows
{
    class ConstBaseWorkers:Person
    {
        private int determined_month_work;
        
        /// <summary>
        /// این خاصیت ساعات موظفی کار یک کارمند حقوق ثابت می باشد
        /// </summary>
        public int DeterminedMonthWork
        {
            set
            {
                this.determined_month_work = value;
            }
            get
            {
                return this.determined_month_work;
            }
        }
        public ulong Maliiyat
        {
            get
            {
                ulong Mal;
                if (contractsalary > 10000000)
                {
                    Mal =(ulong)(contractsalary - (contractsalary * 0.01));
                }
                else
                {
                    Mal = 0;
                }
                return Mal;
            }
        }
        public ulong Salary
        {
            get
            {
                return contractsalary;
            }
        }


    }
}
