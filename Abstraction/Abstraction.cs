using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverRiding
{
    class Program
    {
        abstract class Person
        {
            protected int _id;
            protected string _name;

            virtual public void Display()
            {
                

            }
        }

        class Student : Person
        {
            int _roll;
            string _semester;

            public Student(int _id , string _name , int _roll, string _semester)
            {
                base._id = _id;
                base._name = _name;
                this._roll = _roll;
                this._semester = _semester;
            }

            override public void Display()
            {
                
                Console.WriteLine("Id  " + _id);
                Console.WriteLine("Name  " + _name);
                Console.WriteLine("Roll No " + _roll);
                Console.WriteLine("Semester " + _semester);
            }
        }
        static void Main(string[] args)
        {
            Student st = new Student(413, "Waleed", 1007, "8th");
            st.Display();
            Console.ReadLine();
        }
    }
}
