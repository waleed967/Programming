using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        class Vehicle
        {
            public void PressHorn()
            {

                Console.WriteLine("Peep Peep");

            }

            private void MonitorOilTemp()
            {


            }


        }
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            car.PressHorn();
            Console.ReadLine();
        }
    }
}
