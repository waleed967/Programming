using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate int mul(int x, int y);
namespace Delegates
{
    class Program
    {
        private static int mult(int a , int b)
        {
            return a * b;

        }
        static void Main(string[] args)
        {
            mul obj = new mul(mult);
            int result = obj(3, 2);
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
