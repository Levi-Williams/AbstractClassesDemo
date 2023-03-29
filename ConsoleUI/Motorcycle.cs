using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("I only recommend driving this after some formal lessons");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("You drive this with a handlebar and 2 wheels");
        }

        public bool  hasSideCar = false;

    }
}
