using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_11_Employee
{

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public static int Count { get; private set; }

        public Employee()
        {
            Name = "";
            Age = -1;
            Position = "";
            Salary = -1;
            Count++;
        }

        //When overloading constructors:
        //Convention 1: keep parameters in the same position as the constructor "telescopese" out
        //Convention 2: MOre complex data types come first
        public Employee(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        //To simplify, I can actually cal another constructor from this constructor using the :this()
        //The other constructor is called first, then this constructor runs.
        public Employee(string name, int age, string position, int salary) : this (name, age)
        {
            Position = position;
            Salary = salary;
            Count++;
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            Employee b = new Employee("Matt Sauro", 32);
            Employee c = new Employee("Lisa Tosti", 32, "Software Engineer", 1000000);

            Console.WriteLine(a.Age);
            Console.WriteLine(c.Age);
            Console.WriteLine(b.Name);
            Console.WriteLine(c.Name);
            Console.WriteLine(Employee.Count);
            Console.ReadLine();

        }
    }
}
