using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1
{
    // Base class
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class (inherits from Animal)
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    public class Program1
    {
        public static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Eat(); // Inherited method
            myDog.Bark(); // Own method
        }
    }
}

// Notes:
// Single Inheritance means a class inherits from one base class only.
// In this example, 'Dog' inherits from 'Animal'.
// 'Dog' can use methods of 'Animal' (like Eat()) and also has its own methods (like Bark()).
// Syntax: class DerivedClass : BaseClass
// This helps in code reuse and organization.