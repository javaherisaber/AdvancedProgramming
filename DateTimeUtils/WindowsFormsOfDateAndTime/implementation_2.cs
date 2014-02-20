using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsOfDateAndTime
{
    class implementation_2:Valed
    {
        private ulong sec;
        public int Year
        {
            set
            {
                ulong V =(ulong) value;
                V = (V <= 0) ? 1 : V;
                ulong temp2 = (ulong)this.Year;
                this.sec -= (temp2 * 34819200);
                this.sec += (V * 34819200);
            }
            get
            {
                return (int) (this.sec / 34819200);
            }
        }
        public int Month
        {
            set
            {
                ulong V =(ulong) value;
                V = (V <= 0) || (V > 12) ? 1 : V;
                ulong temp2 = (ulong)this.Month;
                this.sec -= (temp2 * 2678400);
                this.sec += (V * 2678400);
            }
            get
            {
                return (int)((this.sec % 34819200) / 2678400);
            }
        }
        public int Day
        {
            set
            {
                    ulong V = (ulong)value;
                    if (V <= 0 || V >30)
                    {
                        V = 1;
                    }
                    ulong temp3 = (ulong) this.Day;
                    this.sec =this.sec - (temp3 * 86400);
                    this.sec += (V * 86400);
            }
            get
            {

                return (int)(((this.sec % 34819200) % 2678400) / 86400);
            }
        }
        public int Hour
        {
            set
            {
                ulong V =(ulong) value;
                V = (V < 0) || (V > 23) ? 0 : V;
                ulong temp2 = (ulong)this.Hour;
                this.sec -= (temp2 * 3600);
                this.sec +=(V * 3600);
            }
            get
            {
                return (int)((((this.sec % 34819200) % 2678400) % 86400) / 3600);
            }
        }
        public int Min
        {
            set
            {
                ulong V =(ulong) value;
                V = (V < 0) || (V >= 60) ? 0 : V;
                ulong temp2 = (ulong)this.Min;
                this.sec -= (temp2 * 60);
                this.sec +=(V * 60);
            }
            get
            {
                return (int)(((((this.sec % 34819200) % 2678400) % 86400) % 3600) / 60);
            }
        }
        public int Sec
        {
            set
            {
                ulong V =(ulong) value;
                V = (V < 0) || (V >= 60) ? 0 : V;
                ulong temp2 = (ulong)this.Sec;
                this.sec -= temp2;
                this.sec +=(V);
            }
            get
            {
                return (int)(((((this.sec % 34819200) % 2678400) % 86400) % 3600) % 60);
            }
        }

        public implementation_2()
        {
            SetValues(1393, 01, 01, 15, 27, 39);
        }//default constructor
        public implementation_2(int year, int month, int day, int hour,int min, int sec)
         {
           SetValues(year, month, day,hour, min, sec);
         }//second constructor
        public implementation_2(int year, int month, int day)
         {
           SetValues(year, month, day);
         }//third constructor
        private void SetValues(int ye, int mon, int day, int hou = 0, int min = 0, int sec = 0)
        {
            this.Year = ye;
            this.Month = mon;
            this.Day = day;
            this.Hour = hou;
            this.Min = min;
            this.Sec = sec;
        }
        public override void Add(ushort WhichParameter, int AmountOfParameter)//WhichParameter is :1-year 2-month 3-day 4-hour 5-min 6-sec
        {
            switch (WhichParameter)
            {
                case 1:
                    this.Year += AmountOfParameter;
                    break;
                case 2:
                    mon_adder(AmountOfParameter);
                    break;
                case 3:
                    day_adder(AmountOfParameter);
                    break;
                case 4:
                    hour_adder(AmountOfParameter);
                    break;
                case 5:
                    min_adder(AmountOfParameter);
                    break;
                case 6:
                    sec_adder(AmountOfParameter);
                    break;
            }
        }
        private void mon_adder(int Input)
        {
            int rest = 0, right = 0;
            if (Input + this.Month <= 12)
            {
                this.Month += Input;
            }
            else
            {

                Input += this.Month;
                right = Input / 12;
                rest = Input % 12;
                this.Year += right;
                this.Month = rest;
            }
        }
        private void day_adder(int Input)
        {
            int rest = 0, right = 0;
            if (Input + this.Day <= 30)
            {
                this.Day += Input;
            }
            else
            {
                Input += this.Day;
                right = Input / 30;
                rest = Input % 30;
                this.Day = rest;
                mon_adder(right);
            }
        }
        private void hour_adder(int Input)
        {
            int rest = 0, right = 0;
            if (Input + this.Hour < 24)
            {
                this.Hour += Input;
            }
            else
            {
                Input += this.Hour;
                right = Input / 24;
                rest = Input % 24;
                this.Hour = rest;
                day_adder(right);
            }
        }
        private void min_adder(int Input)
        {
            int rest = 0, right = 0;
            if (Input + this.Min < 60)
            {
                this.Min += Input;
            }
            else
            {
                Input += this.Min;
                right = Input / 60;
                rest = Input % 60;
                this.Min = rest;
                hour_adder(right);
            }
        }
        private void sec_adder(int Input)
        {
            int rest = 0, right = 0;
            if (Input + this.Sec < 60)
            {
                this.Sec += Input;
            }
            else
            {
                Input += this.Sec;
                right = Input / 60;
                rest = Input % 60;
                this.Sec = rest;
                min_adder(right);
            }
        }

        public override void TurnDown(ushort WhichParameter, int AmountOfParameter)//WhichParameter is :1-year 2-month 3-day 4-hour 5-min 6-sec
        {
            switch (WhichParameter)
            {
                case 1:
                    this.Year -= AmountOfParameter;
                    break;
                case 2:
                    mon_decreasor(AmountOfParameter);
                    break;
                case 3:
                    day_decreasor(AmountOfParameter);
                    break;
                case 4:
                    hour_decreasor(AmountOfParameter);
                    break;
                case 5:
                    min_decreasor(AmountOfParameter);
                    break;
                case 6:
                    sec_decreasor(AmountOfParameter);
                    break;
            }

        }
        private void mon_decreasor(int Amount)
        {
            int rest = 0, right = 0;
            if (Amount < this.Month)
            {
                this.Month -= Amount;
            }
            else if (Amount == this.Month)
            {
                this.Year -= 1;
                this.Month = 12;
            }
            else if (Amount > this.Month)
            {
                right = Amount / 12;
                rest = Amount % 12;
                this.Year -= right;
                if (rest < this.Month)
                {
                    this.Month -= rest;
                }
                else if (rest == this.Month)
                {
                    this.Year -= 1;
                    this.Month = 12;
                }
                else if (rest > this.Month)
                {
                    this.Year -= 1;
                    rest -= this.Month;
                    this.Month = (12 - rest);
                }
            }
        }
        private void day_decreasor(int Amount)
        {
            int rest = 0, right = 0;
            if (Amount < this.Day)
            {
                this.Day -= Amount;
            }
            else if (Amount == this.Day)
            {
                this.Day = 30;
                mon_decreasor(1);            
            }
            else if (Amount > this.Day)
            {
                right = Amount / 30;
                rest = Amount % 30;
                mon_decreasor(right);
                if (rest < this.Day)
                {
                    this.Day -= rest;
                }
                else if (rest == this.Day)
                {
                    mon_decreasor(1);
                    this.Day = 30;
                }
                else if (rest > this.Day)
                {
                    mon_decreasor(1);
                    rest -= this.Day;
                    this.Day = (30 - rest);
                }
            }

        }
        private void hour_decreasor(int Amount)
        {
            int rest = 0, right = 0;
            if (Amount < this.Hour)
            {
                this.Hour -= Amount;
            }
            else if (Amount == this.Hour)
            {
                this.Hour = 0;
            }
            else if (Amount > this.Hour)
            {
                right = Amount / 24;
                rest = Amount % 24;
                day_decreasor(right);
                if (rest < this.Hour)
                {
                    this.Hour -= rest;
                }
                else if (rest == this.Hour)
                {
                    this.Hour = 0;
                }
                else if (rest > this.Hour)
                {
                    day_decreasor(1);
                    rest -= this.Hour;
                    this.Hour = (24 - rest);
                }
            }
        }
        private void min_decreasor(int Amount)
        {
            int rest = 0, right = 0;
            if (Amount < this.Min)
            {
                this.Min -= Amount;
            }
            else if (Amount == this.Min)
            {
                this.Min = 0;
            }
            else if (Amount > this.Min)
            {
                right = Amount / 60;
                rest = Amount % 60;
                hour_decreasor(right);
                if (rest < this.Min)
                {
                    this.Min -= rest;
                }
                else if (rest == this.Min)
                {
                    this.Min = 0;
                }
                else if (rest > this.Min)
                {
                    hour_decreasor(1);
                    rest -= this.Min;
                    this.Min = (60 - rest);
                }
            }
        }
        private void sec_decreasor(int Amount)
        {
            int rest = 0, right = 0;
            if (Amount < this.Sec)
            {
                this.Min -= Amount;
            }
            else if (Amount == this.Sec)
            {
                min_decreasor(1);
                this.Sec = 0;
            }
            else if (Amount > this.Sec)
            {
                right = Amount / 60;
                rest = Amount % 60;
                min_decreasor(right);
                if (rest < this.Sec)
                {
                    this.Sec -= rest;
                }
                else if (rest == this.Sec)
                {
                    min_decreasor(1);
                    this.Sec = 0;
                }
                else if (rest > this.Sec)
                {
                    min_decreasor(1);
                    rest -= this.Sec;
                    this.Sec = (60 - rest);
                }
            }
        }
        public override ulong ConvertDate(ushort ToWhichParameter)//ToWhichParameter is :1-day 2-hour 3-min 4-sec
        {
            ulong Time=0;
            switch (ToWhichParameter)
            {
                case 1 :
                    Time = this.sec / 86400;
                    break;
                case 2 :
                    Time = this.sec / 3600;
                    break;
                case 3 :
                    Time = this.sec / 60;
                    break;
                case 4 :
                    Time = this.sec;
                    break;
            }
            return Time;
        }
        /// <summary>
        /// this code has been changed again
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public override string ShowTime(ushort Format)//1-format 1    2-format 2
        {
            string[] shamsi_month = new string[12] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };//12 row is created for 12 month with name of month
            string time = "";
            if (Format == 1)
            {
                time = this.Hour + ":" + this.Min + " " + this.Day + "/" + this.Month + "/" + this.Year;
            }
            else
            {
                if (this.Hour > 12)
                {
                    time = (this.Hour - 12) + ":" + this.Min + " " + "عصر" + " " + this.Day + " " + shamsi_month[this.Month - 1] + " " + this.Year;
                }
                else
                {
                    time = this.Hour + ":" + this.Min + " " + "صبح" + " " + this.Day + " " + shamsi_month[this.Month - 1] + " " + this.Year;
                }
            }
            return time;
        }
     }
}
