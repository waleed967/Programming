using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        class Rectangle
        {
            private int _width;
            private int _height;

            public int Width
            {
                get
                {
                    return _width;
                }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        throw new OverflowException();
                    }

                    _width = value;
                }


            }

            public int Height
            {
                get
                {
                    return _height;
                }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        throw new OverflowException();
                    }

                    _height = value;
                }


            }



        }




        static void Main(string[] args)

        {
            Rectangle rect = new Rectangle();
            rect.Width = 50;
            rect.Height = 25;

            Rectangle square = new Rectangle();
            square.Height = square.Width = 40;
            Console.WriteLine(rect.Height);
            Console.WriteLine(square.Width);
            rect.Height = 60;
            Console.ReadLine();
            
        }
    }
}
