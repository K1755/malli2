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
    /// Radio class...
    /// </summary>
    class Radio
    {
        private const int VolumeMin = 0;
        private const int VolumeMax = 9;
        private const double FrequencyMin = 2000.0;
        private const double FrequencyMax = 26000.0;

        public bool IsOpen { get; set; }

        private int volume; 
        public int Volume
        {
            get { return volume;  }
            set
            {
                if (!IsOpen)
                {
                    Console.WriteLine("You need to open radio first to set volume.");
                    return;
                }
                if (value < VolumeMin)
                {
                    Console.WriteLine("Too low volume {0}, set to minimium!", value);
                    volume = VolumeMin;
                }
                else if (value > VolumeMax)
                {
                    Console.WriteLine("Too much volume {0}, set to maximum!", value);
                    volume = VolumeMax;
                }
                else volume = value;
            }
        }

        private double frequency;
        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (!IsOpen)
                {
                    Console.WriteLine("You need to open radio first to set frequency.");
                    return;
                }
                if (value < FrequencyMin)
                {
                    Console.WriteLine("Too low frequency {0}, set to minimium!", value);
                    frequency = FrequencyMin;
                }
                else if (value > FrequencyMax)
                {
                    Console.WriteLine("Too high frequency {0}, set to maximum!", value);
                    frequency = FrequencyMax;
                }
                else frequency = value;
            }
        }

        public Radio()
        {
            IsOpen = false;
            volume = VolumeMin;
            frequency = FrequencyMin;
        }


        public override string ToString()
        {
            return "Radio is open : " + IsOpen + " volume : " + Volume + " Frequency : " + Frequency;
        }

    }
}
