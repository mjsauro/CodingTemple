using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ns1
{
    class Program
    {
        static void Main(string[] args)
        {
            ns2.Person person2 = new ns2.Person();
            ns3.Person person3 = new ns3.Person();

            person2.Print();
            person3.Print();
            Console.ReadLine();
        }
    }
}

namespace ns2
{
    class Person
    {
        public void Print()
        {
            Console.WriteLine("I am from NS2");
        }
    }
}

namespace ns3
{
   class Person
    {
        public void Print()
        {
            Console.WriteLine("I am from NS3");
        }
    }
}