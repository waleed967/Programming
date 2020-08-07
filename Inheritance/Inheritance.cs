using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Calcultor
    {
        protected double num1;

        public void Input()
        {
            Console.WriteLine("Enter First Num");

            num1 = Convert.ToDouble(Console.ReadLine());
        }
    }

    class CalculatorChild : Calcultor
    {
        private double num2;

        public void InputChild()
        {
            Input();
            Console.WriteLine("Enter Second Num");
            num2 = Convert.ToDouble(Console.ReadLine());
        }

        public void Sub()
        {

            double sub = num1 - num2;
            Console.WriteLine("The Substraction Is " +sub);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorChild ic = new CalculatorChild();

            ic.InputChild();
            ic.Sub();

            Console.ReadLine();
        }
    }
}
