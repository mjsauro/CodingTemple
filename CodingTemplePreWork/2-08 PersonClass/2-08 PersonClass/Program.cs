using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_08_PersonClass
{

    //Class Definitions:
    //Access Modifiers - public, internal (internal by default)
    //Behavior Modifiers - sealed (no inheritance, not recommended), abstract (cannot instantiate new inherited classes, also not recommended)
    //  instead of an abstract class, use an interface
    //every class inherits from object by default unless other specified
    //Class name: Pascal cased, no spaces, avoid underscores
    //Inheritance rules: after a : I can specify one base class (Defaults to System.Object if not specified)
    //  and may Interfaces (comma separated)
    class Person
    {
        //This is an explicit constructor
        public Person()
        {

        }

        //Properties
        //Pascal Cased the get/ set operators can be public, private, or protected
        //You can just do get or set by themselves
        public int Age { get; set; }
        public string Name { get; set; }

        //This is a field, it is totally encapulsated from external access (no get / set)
        private string _Gender;

        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }
        
        //This is an instace method, and the better way to write the IsAdult method
        //
        public bool IsAdult()
        {
            return this.Age >= 18;
        }

        public string WhatGender()
        {
            return this.Gender; //= string.Format("The gender is: {0}", Gender);
        }

        public string WhatName()
        {
            return Name = Name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //This invokes the constructor
            //When call "New" on an object. I'm instructing the .NET runtime to allocate memory for that object
            //The runtime will look at all of the fields/properties on that object
            //  to determine the appropriate amount of memory
            Person p1 = new Person();

            p1.Name = "Matt";
            p1.Age = 32;
            p1.Gender = "Male";

            Person p2 = new Person();
            p2.Name = "Lisa";
            p2.Age = 32;
            p2.Gender = "Female";

            Console.WriteLine("{0} is an andult {1}?  Gender is {2}", p1.WhatName(), p1.IsAdult(), p1.WhatGender());
            Console.WriteLine("{0} is an andult {1}?  Gender is {2}", p2.WhatName(), p2.IsAdult(), p2.WhatGender());
            Console.ReadLine();
   
        }
    }
}
