using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface Icustomer1
    {
        void Print1();

    }

    interface Icustomer2 : Icustomer1
    {
        void Print2();

    }
    class Customer : Icustomer2
    {
        public void Print2()
        {
        Console.WriteLine("Print2");
        }
         public void Print1()
        {
        Console.WriteLine("Print1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Customer c = new Customer();
        c.Print1();
        c.Print2();
        Console.ReadKey();
        }
    }

