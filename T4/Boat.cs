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
    class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }
        public override string ToString()
        {
            return base.ToString() + " SeatCount:" + SeatCount + " BoatType:" + BoatType;
        }
    }
}
