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
    /// DerivedClass class news one BaseClass method
    /// </summary>
    class DerivedClass : BaseClass
    {
        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }
}
