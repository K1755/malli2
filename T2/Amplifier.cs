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
    /// Amplifier class...
    /// </summary>
    class Amplifier
    {
        private const int minVolume = 0;
        private const int maxVolume = 100;
        private int volume;

        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                if (value < minVolume)
                {
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : " + minVolume);
                    volume = minVolume;
                }
                else if (value > maxVolume)
                {
                    Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum : " + maxVolume);
                    volume = maxVolume;
                }
                else
                {
                    Console.WriteLine("-> Amplifier volume is set to : " + value);
                    volume = value;
                }
            }
        }
    }
}
