using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle1
{
    class Program
    {

        public class Triangle
        {
            private int _height;
            private int _baseLength;

            public int Height
            {
                get
                {
                    return _height;
                }

                set
                {

                    if(value < 1 || value > 100)
                    {
                        throw new OverflowException();
                    }
                    _height = value;
                }

            }

            public int BaseLength
            {
                get
                {
                    return _baseLength;
                }

                set
                {

                    if (value < 1 || value > 100)
                    {
                        throw new OverflowException();
                    }
                    _baseLength = value;
                }

            }

            public double Area
            {
                get
                {
                    return _height * _baseLength * 0.5;
                }
            }
            public Triangle()
            {

                Console.WriteLine("Constructor");
                _height = _baseLength = 1;
         


            }



        }
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Height:\t{0}", triangle.Height);
            Console.WriteLine("BaseLength:\t{0}", triangle.BaseLength);
            Console.WriteLine("Area:\t{0}", triangle.Area);
            Console.ReadLine();

        }
    }
}
