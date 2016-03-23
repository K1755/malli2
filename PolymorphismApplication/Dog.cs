/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace PolymorphismApplication
{
    /// <summary> 
    /// Dog class...
    /// </summary>
    class Dog : Animal
    {
        public override int Legs
        {
            get
            {
                return 4;
            }
        }

        public override void Talk()
        {
            Console.WriteLine("Wuw!");
        }
    }
}
