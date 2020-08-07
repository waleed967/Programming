using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexxers
{

    public class person
    {
        string[] persons = { "Ali", "Akbar", "Ahmed" };
        public string this[int index]
        {
            get
            {
                return persons[index];
            }

            set
            {
                persons[index] = value;


            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            person obj = new person();

            Console.WriteLine("First person {0}", obj[0]);
            Console.ReadLine();

        }
    }
}
