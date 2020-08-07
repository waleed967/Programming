using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Student
    {

        private int _id;
        private string _email;
        private string _name;


        public Student(int _id, string _email, string _name)
        {
            this._id = _id;
            this._email = _email;
            this._name = _name;
        }
        public int getId()
        {
            return this._id;

        }

        public string getEmail()
        {
            return this._email;

        }


        public string getName()
        {
            return this._name;

        }



        static void Main(string[] args)
        {

            Student s = new Student(21, "w@yahoo.com", "Ahmed");

            Console.WriteLine("Student Id is"    +s.getId());
            Console.WriteLine("Student Email is" + s.getEmail());
            Console.WriteLine("Student Name is"  + s.getName());
            Console.ReadLine();
        }
    }
}
