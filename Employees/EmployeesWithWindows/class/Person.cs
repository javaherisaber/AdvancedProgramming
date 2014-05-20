using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeesWithWindows
{
    class Person
    {
        protected string fname;
        protected string lname;
        protected string fathername;
        protected string codemelli;
        protected string birthdayplace;
        protected string address;
        protected string birthdaydate;
        protected ulong contractsalary;
        protected int amount_of_work;
    
        public string Fname
        {
            set
            {
                this.fname = value;
            }
            get
            {
                return this.fname;
            }
        }
        public string Lname
        {
            set
            {
                this.lname = value;
            }
            get
            {
                return this.lname;
            }
        }
        public string Fathername
        {
            set
            {
                this.fathername = value;
            }
            get
            {
                return this.fathername;
            }
        }
        public string Codemelli
        {
            set
            {
                this.codemelli = value;
            }
            get
            {
                return this.codemelli;
            }
        }
        public string BirthdayPlace
        {
            set
            {
                this.birthdayplace = value;
            }
            get
            {
                return this.birthdayplace;
            }
        }
        public string Address
        {
            set
            {
                this.address = value;
            }
            get
            {
                return this.address;
            }
        }
        public string BirthdayDate
        {
            set
            {
                this.birthdaydate = value;
            }
            get
            {
                return this.birthdaydate;
            }
        }
        public ulong ContractSalary
        {
            set
            {
                this.contractsalary = value;
            }
            get
            {
                return this.contractsalary;
            }
        }
        public int Amount_Of_Work
        {
            set
            {
                this.amount_of_work = value;
            }
            get
            {
                return this.amount_of_work;
            }
        }

    }
}
