using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private readonly IVehicleBuilder _vehicleBuilder;
        public Director(IVehicleBuilder vehicleBuilder) {
        
            _vehicleBuilder = vehicleBuilder;
        }

        public void BuildSportCar()
        {
            _vehicleBuilder.BuildBodyWorkType("Sport Car");
            _vehicleBuilder.BuildSpareWheels(0);
            _vehicleBuilder.BuildSeats(2);
            _vehicleBuilder.BuildDoors(3);
            _vehicleBuilder.BuildEngine(3.0);
            _vehicleBuilder.BuildLights();
        }

        public void BuildSUV() { 
            _vehicleBuilder.BuildBodyWorkType("SUV");
            _vehicleBuilder.BuildSpareWheels(1);
            _vehicleBuilder.BuildSeats(5);
            _vehicleBuilder.BuildDoors(5);
            _vehicleBuilder.BuildEngine(2.0);
            _vehicleBuilder.BuildLights();
        }
    }
}
