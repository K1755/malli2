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
    /// Elevator class...
    /// </summary>
    class Elevator
    {
        // min and max values
        private const int minFloor = 1;
        private const int maxFloor = 5;
        // first floor by default
        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < minFloor)
                {
                    Console.WriteLine("Floor is too small!");
                }
                else if (value > maxFloor)
                {
                    Console.WriteLine("Floor is too big!");
                }
                else
                {
                    floor = value;
                }
            }
        }
    }
}
