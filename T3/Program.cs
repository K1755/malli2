/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T3
{
    /// <summary> 
    /// This class demonstrates Employee and Boss classes...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create a one employee
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 1200.00;
            Console.WriteLine(employee.ToString());

            // create a one boss
            Boss boss = new Boss();
            boss.Name = "Jussi Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000.00;
            boss.Car = "Audi";
            boss.Bonus = 5000.00;
            Console.WriteLine(boss.ToString());

            Boss anotherBoss = new Boss("Janne Husso", "Head of Department", 12000.00);
            anotherBoss.Car = "Jeep";
            anotherBoss.Bonus = 2200.00;
            Console.WriteLine(anotherBoss.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
