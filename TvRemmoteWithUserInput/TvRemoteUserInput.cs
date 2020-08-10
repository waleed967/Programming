using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteWithUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            double tv;
            Console.WriteLine("Press any key");
            tv = Convert.ToDouble(Console.ReadLine());
            tv = Convert.ToDouble(Console.ReadLine());

            switch (Convert.ToDouble(tv))
            {
                case 1 :
                    Console.WriteLine("Tv TurnOn");
                    break;
                case 2 :
                    Console.WriteLine("Volume Up");
                    break;
                case 3 :
                    Console.WriteLine("Volume Down");
                    break;
                case 4 :
                    Console.WriteLine("Tv TurnOff");
                    break;
                default:
                    Console.WriteLine("Cannot Perform any Operation");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}

        
