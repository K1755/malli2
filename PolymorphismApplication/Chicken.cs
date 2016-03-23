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
    /// Chiecken class...
    /// </summary>
    class Chicken : Animal
    {
        public override int Legs
        {
            get
            {
                return 2;
            }
        }
        
        public override void Talk()
        {
            Console.WriteLine("CotCot!");
        }
        
        /*
        public new void Talk()
        {
            Console.WriteLine("CotCot!");
        }
        */

    }
}
