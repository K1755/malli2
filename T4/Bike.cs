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
    /// Boat class...
    /// </summary>
    class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }
        public override string ToString()
        {
            return base.ToString() + " GearWheels:" + GearWheels + " GearName:" + GearName;
        }
    }
}
