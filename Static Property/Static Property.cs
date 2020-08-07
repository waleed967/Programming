using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticProperty
{
    class University
    {
        private static string _university;
        

        public static string universityname{
            get
            {

                return _university;

            }



            set {
                if (string.IsNullOrEmpty(value))
                {

                    Console.WriteLine("Cannot Enter Null or Empty");
                }
                else
                {
                    _university = value;

                }
                _university = value;

            } }

        static void Main(string[] args)
        {
            University.universityname = "Numl";
            Console.WriteLine("University is    " + University.universityname);
            Console.ReadLine();
        }
    }
}
