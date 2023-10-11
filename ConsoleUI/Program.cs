using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

           
           

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /* Done
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * Done
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
          
            {
                HasTrunk = true,
                Year = "2017",
                Make = "Ford",
                Model = "GT"              
            };

            var motorcycle1 = new Motorcycle()
            {
                HasSaddlebags = false,
                Year = "2023",
                Make = "Suzuki",
                Model = "GXR"
            };
            Vehicle vehicle1 = new Car()
            {
                HasTrunk = true,
                Year = "2023",
                Make = "Maserati",
                Model = "MC20",
            };

            Vehicle vehicle2 = new Motorcycle()

            {
                HasSaddlebags = true,
                Year = "2014",
                Make = "Harley Davidson",
                Model = "FLHXS"
            };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                if (vehicle is Car car && car.HasTrunk)
                {
                    Console.WriteLine($"This {car.Model} has a trunk.");
                    
                }
                else if (vehicle is Motorcycle motorcycle && motorcycle.HasSaddlebags)
                {
                    Console.WriteLine($"This {motorcycle.Model} has saddlebags.");
                }

                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }
            
            // Call each of the drive methods for one car and one motorcycle *Done

            #endregion  
            // Why can't I just delete end region and the readline?
            Console.ReadLine();
        }

    }
}
