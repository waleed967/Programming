using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IEmployee
    {

        void show();
    }

    class IStudent : IEmployee
    {
        public void show()
        {
            Console.WriteLine("Getting Data From interface");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IStudent st = new IStudent();

            st.show();
            Console.ReadLine();

        }
    }
}
