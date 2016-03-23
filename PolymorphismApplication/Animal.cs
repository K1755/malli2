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
    /// Animal class...
    /// </summary>
    class Animal
    {
        public virtual int Legs
        {
            get
            {
                return 0;
            }
        }

        public virtual void Talk()
        {
            Console.WriteLine("Talk!");
        }
    }
}
