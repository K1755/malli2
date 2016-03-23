/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;
using System.Collections.Generic;

namespace PolymorphismApplication
{
    /// <summary> 
    /// This class creates object from Animal, Dog, Cat and Chicken classes. Just testing OOP.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            Animal animal1 = new Dog();
            animal1.Talk(); // Wuw!
            Console.WriteLine("animal1 has {0} legs.", animal1.Legs);
            Console.WriteLine("animal1 type is {0}.", animal1.GetType());

            // Polymorphism
            Animal animal2 = new Cat();
            animal2.Talk(); // Miaum!
            Console.WriteLine("animal2 has {0} legs.", animal2.Legs);
            Console.WriteLine("animal1 type is {0}.", animal2.GetType());

            // Polymorphism
            Animal animal3 = new Chicken();
            animal3.Talk(); // CotCot!
            Console.WriteLine("animal3 has {0} legs.", animal3.Legs);
            Console.WriteLine("animal1 type is {0}.", animal3.GetType());

            // a lot of different animals in a list
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());
            animals.Add(new Dog());
            animals.Add(new Cat());
            animals.Add(new Chicken());

            // virtual method talk is invoked on each of the derived classes, not the base class. 
            foreach (Animal animal in animals)
            {
                // note we can handle this with one talk-method!
                animal.Talk();
            }

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
