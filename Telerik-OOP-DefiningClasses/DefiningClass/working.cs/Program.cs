using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working.cs
{
    class Creature
    {
        protected string Name { get; private set; }
        private void Talk()
        {
            Console.WriteLine("I am creature ...");
        }
        protected void Walk()
        {
            Console.WriteLine("Walking ...");
        }
    }
    class Mammal : Creature
    {
        // base.Talk() can be invoked here
        // this.Name can be read but cannot be modified here
    }

    class Dog : Mammal
    {
        public string Breed { get; private set; }
        // base.Talk() cannot be invoked here (it is private)
    }

    class InheritanceAndAccessibility
    {
        static void Main()
        {
            Dog joe = new Dog();
            Console.WriteLine(joe.Breed);
            //joe.Walk(); //is protected and can not be invoked
            // joe.Talk() is private and can not be invoked
            // joe.Name = "Rex"; // Name cannot be accessed here
            // joe.Breed = "Shih Tzu"; // Can't modify Breed
        }
    }

}
