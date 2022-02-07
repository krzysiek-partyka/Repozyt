using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    abstract class Vehicle
    {
        
        public string VehicleTyp { get; set; }
        public string VehicleColor { get; set;}

        public Vehicle(string vehicleTyp, string vehicleColor)
        {
            VehicleColor = vehicleColor;
            VehicleTyp = vehicleTyp;
        }
        public override string ToString()
        {
            return $"{VehicleColor}, {VehicleTyp}";
        }

        public abstract void MakeSound();

        public virtual void PresentVehicle(Vehicle vehicle)
        {
            MakeSound();
            
            Console.WriteLine($"Color: {vehicle.VehicleColor} Type: {vehicle.VehicleTyp}");
        }

    }
}
