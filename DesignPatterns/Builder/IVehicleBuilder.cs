using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IVehicleBuilder
    {
        void BuildEngine(double ccLiters);
        void BuildWheels(int wheels);
        void BuildDoors(int doors);
        void BuildLights();
        void BuildMirrors(int mirrors);
        void BuildSeats(int seats);
        void BuildSpareWheels(int spareWheels);
        void BuildBodyWorkType(string bodyWorkType);
    }
}
