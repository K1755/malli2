/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T5
{
    /// <summary> 
    /// This class creates object from Radio class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create a radio object
            Radio radio = new Radio();
            // open and set values
            radio.IsOpen = true;
            radio.Volume = 5;
            radio.Frequency = 3000.00;
            Console.WriteLine(radio.ToString());

            // try wrong volume
            radio.Volume = 100;
            Console.WriteLine(radio.ToString());

            // try wrong frequency
            radio.Frequency = 100000.00;
            Console.WriteLine(radio.ToString());

            // close and try set volume
            radio.IsOpen = false;
            radio.Volume = 8;
            Console.WriteLine(radio.ToString());

            // try frequency
            radio.Frequency = 9000.00;
            Console.WriteLine(radio.ToString());

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
