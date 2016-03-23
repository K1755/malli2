/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;

namespace PersonApplication
{
    /// <summary> 
    /// This class creates object from Teacher and Student classes. Just testing OOP.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // create one person
            Person person = new Person();
            person.FirstName = "Kirsi";
            person.LastName = "Kernel";
            person.Address = "torikatu 1";
            person.Age = 30;
            person.PhoneNumber = "020-12345678";
            Console.WriteLine(person.ToString());

            // create one teacher
            Teacher teacher = new Teacher();
            teacher.FirstName = "Teppo";
            teacher.LastName = "Konsoli";
            teacher.Address = "piippukatu 2";
            teacher.Age = 40;
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D100";
            Console.WriteLine(teacher.ToString());

            // create one student
            Student student = new Student("Minna", "Husso", "J9090");
            student.Address = "kilju 3";
            student.Age = 20;
            student.PhoneNumber = "040-12345678";
            Console.WriteLine(student.ToString());

            // do something methods
            person.PersonMethod(); // This method belongs to Person!
            teacher.PersonMethod(); // This method belongs to Person!
            teacher.TeacherMethod(); // This method belongs to Teacher!
            student.PersonMethod(); // This method belongs to Person!
            student.StudentMethod(); // This method belongs to Student!

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
