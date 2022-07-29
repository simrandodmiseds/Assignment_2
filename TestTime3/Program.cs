using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTime3
{
    public struct Time1
    {
        private  int minutes, hours;
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
        public static Time1 operator +(Time1 t1,Time1 t2)
        {
            Time1 temp = new Time1();
            temp.hours = t2.hours + t1.hours;
            temp.minutes = t2.minutes + t1.minutes;
            return (temp);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int hr, mn;
            Console.WriteLine("Enter hrs:");
            hr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mins:");
            mn = Convert.ToInt32(Console.ReadLine());
            Time1 t1 = new Time1(hr,mn);

            int hh, mm;
            Console.WriteLine("Enter hrs:");
            hh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mins:");
            mm = Convert.ToInt32(Console.ReadLine());
            Time1 t3=t1 + new Time1(hh,mm);
            Console.WriteLine("Time: " +t3.ToString());
        }
    }
}
