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
    /// Employee class...
    /// </summary>
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string profession, double salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name:" + Name + " Profession:" + Profession + " Salary:" + Salary;
        }
    }
}
