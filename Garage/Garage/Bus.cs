using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Bus : Vehicle
    {
        public Bus (string vehicleTyp, string vehicleColor) : base(vehicleTyp, vehicleColor)
        {
            VehicleColor = vehicleColor;
            VehicleTyp = vehicleTyp;
        }

        public override void MakeSound()
        {
            Console.Beep();
            Console.Beep();
            Console.Beep();
        }
        public override void PresentVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Color: {vehicle.VehicleColor} Type: {vehicle.VehicleTyp}");
            MakeSound();
        }
    }
}
