/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace T6
{
    /// <summary> 
    /// This class creates object from Book, CD and DVD class. Just testing OOP.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Name = "Aapinen";
            book.ISBN = "9090-9090-9090";
            Console.WriteLine("Book : " + book.Name + " " + book.ISBN);

            CD cd = new CD();
            cd.Artist = "Metallica";
            cd.Name = "Master of Puppets";
            Console.WriteLine("CD : " + cd.Artist + " " + cd.Name);

            DVD dvd = new DVD();
            dvd.Name = "Wimbledon 2015";
            dvd.Format = "MP4";
            Console.WriteLine("Name : " + dvd.Name + " " + dvd.Format);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
