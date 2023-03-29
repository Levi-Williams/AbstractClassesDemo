using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in  the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion

            var vehicles = new List<Vehicle>();

            var malibu = new Car() { make = "Chevrolet", model = "Malibu", year = "2018", hasTrunk = true };

            vehicles.Add(malibu);

            var harley = new Motorcycle() { hasSideCar = false };

            vehicles.Add(harley);

            Vehicle truck = new Car() { make = "Ford", model = "Ranger", year = "2021" };

            vehicles.Add(truck);

            Vehicle harleyMotorcyle = new Motorcycle() { make = "Harley Davidson", model = "Street Glide", year = "2020", hasSideCar = false };

            vehicles.Add(harleyMotorcyle);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.make);
                Console.WriteLine(vehicle.model);
                Console.WriteLine(vehicle.year);
                Console.WriteLine(vehicle.hasTrunk);
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
               
            }

            malibu.DriveAbstract();
            harleyMotorcyle.DriveVirtual();
        }
    }
}
