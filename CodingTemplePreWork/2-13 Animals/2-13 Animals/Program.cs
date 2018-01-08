using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_13_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal(9);
            Dog d = new Dog(2);
            Cat c = new Cat(5);
            a.Speak();
            d.Speak();
            c.Speak();

            //AbstractAnimal aa = new ??  //I can't create an abstract object!
            ConcreteCat cc = new ConcreteCat();

            //IAnimal i = new ??  //Can't create instances of interfaces
            Horse h = new Horse();
            h.Speak();

            //Not real common, but legal!
            IAnimal iH = new Horse();
            iH.Speak();

            //More common: methods accepting interfaces as parameters:
            PetTheAnimal(h);

            cc.Speak();
            Console.ReadLine();
        }

        //This is useful because anything that implements IAnimal is an eligible argument.  
        //Super flexible!
        public static void PetTheAnimal(IAnimal animal)
        {
            animal.Speak();
        }
    }


    public class Dog : Animal
    {
        //By calling :base(age), I'm giving the compiler an instruction 
        //on how to call the base-class constructor with a parameter
        //I need to do that here because the Animal class's constructor requires an age!
        public Dog(int age) : base(age) { }

        //I use the "new" keyword" to get rid of the warning about hiding the Speak method on
        //the Base class.
        //Option 1:
        //public new void Speak()
        //{
        //    Console.WriteLine("Arf");
        //}

        public override void Speak()
        {
            Console.WriteLine("Arf");
        }
    }

    public class Cat : Animal
    {

        public Cat(int age) : base(age) { }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Horse : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Wiiiillllbuurrrr");
        }
    }

    public class ConcreteCat : AbstractAnimal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow (from inside the concrete)");
        }
    }

    public class Animal
    {
        private int Age;

        //One option to fix my compiler error: add a parameterless constructor to animal so that Dog and Cat constructors can call the animal constructor
        //public Animal()
        //{
        //}

        public Animal(int age)
        {
            Age = age;
        }

        //Option 1:
        //public void Speak()
        //{
        //    Console.WriteLine();
        //}

        //Option 2:
        //The virtual keyword indicates that 
        //you intend for derived classes to override this behavior (if they want to)
        public virtual void Speak()
        {
            Console.WriteLine();
        }
    }

    //Abstract classes - any class that inherits from AbstractAnimal *Must* supply
    //an override for all of the abstract method.
    //I can't include abstract methods in a class without marking the class as abstract.
    //I also can't construct an abstract class.
    public abstract class AbstractAnimal
    {
        public abstract void Speak();
    }


    //Abstract classes are kinda crappy because they require you to inherit from something 
    //that's not directly usable - this has a lot of implications we'll see down the road
    //Interfaces are the way to go!
    //Everything on an interface is public, and they should always start with capital I.
    public interface IAnimal
    {
        void Speak();
    }
}
