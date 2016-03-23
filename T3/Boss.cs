/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace T3
{
    /// <summary> 
    /// Boss class...
    /// </summary>
    class Boss : Employee
    {
        public string Car { get; set; }
        public double Bonus { get; set; }

        public Boss()
        {

        }

        public Boss(string name, string profession, double salary) 
            : base(name,profession,salary)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Car:" + Car + " Bonus:" + Bonus;
        }
    }
}
