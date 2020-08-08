using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading
{
    class Mathematics
    {
        public void Add(int a , int b)
        {
            Console.WriteLine("Integer Type");

            Console.WriteLine("Addition   "   + (a + b));


        }
        public double Add(double a, double b)
        {
            Console.WriteLine("Double Type");

            Console.WriteLine("Addition  "   + (a + b));
            return a + b;

        }


        public void Add (string a, string b)
        {
            Console.WriteLine("String Type");

            Console.WriteLine("Addition  " + (a + b));
        }
        static void Main(string[] args)
        {
            Mathematics ma = new Mathematics();
            ma.Add(12, 6);
            ma.Add(13, 2);
            ma.Add("10","5");
            Console.ReadLine();
        }
    }
}
