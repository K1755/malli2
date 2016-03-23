/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T4
{
    /// <summary> 
    /// This class uses Bike and Boat objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create a one Bike instance
            Bike bike = new Bike();
            bike.Name = "Jopo";
            bike.Model = "Street";
            bike.ModelYear = 2016;
            bike.Color = "Blue";
            bike.GearWheels = false;
            bike.GearName = "";
            Console.WriteLine("Bike info {0}", bike.ToString());

            // create another bike instance
            Bike bike2 = new Bike();
            bike2.Name = "Tunturi";
            bike2.Model = "StreetPower";
            bike2.ModelYear = 2010;
            bike2.Color = "Black";
            bike2.GearWheels = true;
            bike2.GearName = "Shimano";
            Console.WriteLine("Bike2 info {0}", bike2.ToString());

            // create a one RowBoat instance
            Boat boat = new Boat();
            boat.Name = "Suvi";
            boat.Model = "S900";
            boat.ModelYear = 1990;
            boat.Color = "White";
            boat.SeatCount = 3;
            boat.BoatType = "Rowboat";
            Console.WriteLine("Boat info {0}", boat.ToString());

            // create a another RowBoat instance
            Boat boat2 = new Boat();
            boat2.Name = "Yamaha";
            boat2.Model = "Model 1000";
            boat2.ModelYear = 2010;
            boat2.Color = "Yellow";
            boat2.SeatCount = 5;
            boat2.BoatType = "Motorboat";
            Console.WriteLine("Boat2 info {0}", boat2.ToString());


            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
