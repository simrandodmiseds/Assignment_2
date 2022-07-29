using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTime
{
    public struct Time
    {
        private readonly int minutes;
        public Time(int hh,int mm)
        {
            this.minutes = 60 * hh + mm;
        }
        public override string ToString()
        {
            return minutes.ToString();
        }
    }
    //public struct Time1
    //{
    //    private readonly int minutes,hours;
    //    public Time1(int hh, int mm)
    //    {
    //        this.hours = hh;
    //        this.minutes = 60 * hh + mm;
    //    }
    //    public override string ToString()
    //    {
    //        int hr = minutes / 60;
    //        int min = minutes % 60;
    //        string s = hr.ToString();
    //        s.Append(':');
    //        //s.Concat(":");
    //        s.Concat(min.ToString());
    //        String.Format(s,":");
    //        //minutes.Append(hr);
    //        //minutes.Append(":");
    //        //minutes.Append( min);
    //        return s;
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            
            int hr,mn;
            Console.WriteLine("Enter hrs:");
            hr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter mins:");
            mn = Convert.ToInt32(Console.ReadLine());
            Time t = new Time(hr, mn);
            Console.WriteLine("Time: "+t.ToString());
        }
    }
}
