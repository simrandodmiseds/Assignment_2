using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time5
{
    public struct Time1
    {
        private int minutes, hours;
        //Time1 t1;
        static Time1 t2;
        public Time1(int hh, int mm)
        {
            this.hours = hh;
            this.minutes = mm;
        }
        public override string ToString()
        {
            string s = null;
            if (minutes >= 60)
            {
                hours = hours + minutes / 60;
                minutes = minutes % 60;
            }
            if (hours >= 24)
                hours = hours % 24;
            if (hours < 10)
                s = "0";
            s = s + hours.ToString();
            s = s + ":";
            if (minutes < 10)
                s = s + "0";
            s = s + minutes;
            return s;
        }
    }
    class Program
    {
        Program p;
        static Program p1;
        static void Main(string[] args)
        {
        }
    }
}
