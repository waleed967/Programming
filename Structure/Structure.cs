using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{


    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }


        }

        public string Name
        {
            get
            { return this._name; }

            set
            { this._name = value; }
        }

        public Customer(int _id, string _name)
        {
            this._id = _id;
            this._name = _name;


        }
        public void PrintDetails()
        {

            Console.WriteLine("Customer Id is" + this._id);
            Console.WriteLine("Customer Name is" + this._name);
}
    }
        class Structure
        {
            static void Main(string[] args)
            {
            Customer cs = new Customer(1, "Sameer");
            cs.PrintDetails();
            Console.ReadLine();
            }
        }
    }
