/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace OverrideNewApplication
{
    /// <summary> 
    /// This class demonstrates objects with uses override and new keywords in methods.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            // object reference can contain own object or derived class object
            BaseClass bcdc = new DerivedClass();

            bc.Method1();           // Base - Method1
            bc.Method2();           // Base - Method2
            dc.Method1();           // Base - Method1
            dc.Method2();           // Derived - Method2
            bcdc.Method1();         // Base - Method1
            bcdc.Method2();         // Base - Method2

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
