﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    /*
           * Create an abstract class called Vehicle * Done
           * The vehicle class shall have three string properties Year, Make, and Model
           * Set the defaults to something generic in the Vehicle class
           * Vehicle shall have an abstract method called DriveAbstract with no implementation
           * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
           */
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Something Generic";
        public string Make { get; set; } = "Something Generic";
        public string Model { get; set; } = "Something Generic";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Default virtual drive method");
        }

    }
}
