using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee("7071314", 100000);
            
            
            a.dispense();
            a.raise(2000);
            a.dispense();
            Console.ReadLine();
        }
    }

    class Employee
    {
        private int Salary;
        private string Id;
        
        public Employee(string id, int salary)
        {
            Salary = salary;
            Id = id;
        }
        public void dispense()
        {
            Console.WriteLine((Salary / 24).ToString("c"));
        }

        public void raise(int amount)
        {
            Console.WriteLine((Salary += amount).ToString("c"));
        }
    }
}
