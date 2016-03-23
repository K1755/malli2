/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T2
{
    /// <summary> 
    /// This class demonstrates Amplifier class...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Amplifier amplifier = new Amplifier();
            bool result;
            do
            {
                Console.Write("Give a new volume value (0-100) > ");
                string line = Console.ReadLine();
                int volume = 0;
                result = int.TryParse(line, out volume);
                if (result)
                {
                    amplifier.Volume = volume;
                }
            } while (result);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
