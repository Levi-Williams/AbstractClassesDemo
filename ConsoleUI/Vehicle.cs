using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
   public abstract class Vehicle
    {
        public string year = "2020";
        public string make = "Chevrolet";
        public string model = "Malibu";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Driving with a wheel and 4 wheels");
        }

        public virtual bool hasTrunk { get; set; }

        public virtual bool hasSideCar { get; set; }


    }
}
