using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConversion
{
    public struct Time1
    {
        private int minutes, hours;
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
        public static implicit operator Time1(int n)
        {
            Time1 t = new Time1(0,0) ;
            t.hours=n/60;
            return t;
        }
        public static explicit operator int(Time1 t)
        {
            int n=(int)t.hours;
            return n;
        }
        public static Time1 operator +(Time1 t1, int t2)
        {
            Time1 temp = new Time1();
            temp.hours = t1.hours;
            temp.minutes = t2 + t1.minutes;
            return (temp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Time1 t1 = new Time1(9, 30);
            Time1 t2 = 120;

            int m1 = (int)t1;
            Console.WriteLine("t1={0} and t2={1} and  m1={2}", t1, t2, m1);
            Time1 t3 = t1 + 45;
            Console.WriteLine("Time: "+t3.ToString());
        }
    }
}
