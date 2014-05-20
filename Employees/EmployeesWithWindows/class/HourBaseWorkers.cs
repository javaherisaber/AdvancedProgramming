using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeesWithWindows
{
    class HourBaseWorkers:Person
    {
        public ulong Salary
        {
            get
            {
                return (ulong)(contractsalary * (ulong)amount_of_work);
            }   
        }
        public ulong Maliiyat
        {
            get
            {
                return (ulong)((contractsalary * (ulong)amount_of_work) * 0.05);
            }
        }
    }
}
