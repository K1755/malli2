/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */

namespace T4
{
    /// <summary> 
    /// Vehicle class...
    /// </summary>
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return "Name:" + Name + " Model:" + Model + " ModelYear:" + ModelYear + " Color:" + Color;
        }
    }
}
