/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace NewOverrideDifferenceApplication
{
    class A
    {
        public virtual void Test() { Console.WriteLine("A-Test()"); }
    }

    class B : A
    {
        public new void Test() { Console.WriteLine("B-Test()"); }
    }

    class C : A
    {
        public override void Test() { Console.WriteLine("C-Test()"); }
    }

    /// <summary> 
    /// This class demonstrates differences with new and override keywords with above classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();

            a.Test(); // output "A-Test()"
            b.Test(); // output "B-Test()"
            c.Test(); // output "C-Test()"  

            a = new B();
            a.Test(); // output --> "A-Test()" // BASE class method used! (new)

            a = new C();
            a.Test(); // output --> "C-Test()" // DERIVED class method used! (override)

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
