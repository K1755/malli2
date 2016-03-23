/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T1
{
    /// <summary> 
    /// This class demonstrates Elevator class...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            bool result;
            do
            {
                // get elevator floor
                Console.WriteLine("Elevator is now in floor : " + elevator.Floor);
                // get a new floor
                Console.Write("Give a new floor number (1-5) > ");
                String line = Console.ReadLine();
                int floor;
                result = Int32.TryParse(line, out floor);
                if (result)
                {
                    // try to set a new floor
                    elevator.Floor = floor;
                }
            } while (result);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
