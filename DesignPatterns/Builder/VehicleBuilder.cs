using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Builder
{
    public class VehicleBuilder : IVehicleBuilder
    {
        public void BuildDoors(int doors)
        {
            WriteLine($"Adding {doors} doors");
        }

        public void BuildEngine(double ccLiters)
        {
            WriteLine($"Adding {ccLiters} liters in engine");
        }

        public void BuildLights()
        {
            WriteLine($"Adding lights");
        }

        public void BuildMirrors(int mirrors)
        {
            WriteLine($"Adding {mirrors} mirrors");
        }

        public void BuildSeats(int seats)
        {
            WriteLine($"Adding {seats} seats");
        }

        public void BuildWheels(int wheels)
        {
            WriteLine($"Adding {wheels} wheels");
        }

        public void BuildSpareWheels(int spareWheels)
        { 
            WriteLine($"Adding {spareWheels} spare Wheels");
        }
        public void BuildBodyWorkType(string bodyWorkType) 
        {
            WriteLine($"Type of bodywork is: {bodyWorkType}");
        }
    }
}
