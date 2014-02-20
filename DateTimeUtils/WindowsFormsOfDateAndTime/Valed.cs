using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsOfDateAndTime
{
   abstract class Valed
    {
       public int Year;
       public int Month;
       public int Day;
       public int Hour;
       public int Min;
       public int Sec;
       public abstract void Add(ushort WhichParameter, int AmountOfParameter);
       public abstract void TurnDown(ushort WhichParameter, int AmountOfParameter);
       public abstract ulong ConvertDate(ushort ToWhichParameter);
       public abstract string ShowTime(ushort Format);
    }
}
