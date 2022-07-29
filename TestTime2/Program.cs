using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTime2
{
    public struct Time1
    {
        private readonly int minutes, hours;
        public Time1(int hh, int mm)
        {
            this.hours = hh;
            this.minutes = 60 * hh + mm;
        }
        public override string ToString()
        {
            int hr=0,min=0;
            string s=null;
            if (minutes >= 60)
            {
                hr = hr + minutes / 60;
                min = minutes % 60;
            }
            if(hours>=24)
                hr = hr % 24;
            if (hr < 10)
                s = "0";
            s =s+hr.ToString();
            s=s+":";
            if (min < 10)
                s = s+"0";
            s = s + min;
            return s;
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

            Time1 t1 = new Time1(hr, mn);
            Console.WriteLine("Time:"+t1.ToString());
        }
    }
}
