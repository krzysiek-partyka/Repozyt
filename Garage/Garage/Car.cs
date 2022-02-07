using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class Car : Vehicle
    {
        public Car(string vehicleTyp, string vehicleColor) : base(vehicleTyp, vehicleColor)
        {
            VehicleColor = vehicleColor;
            VehicleTyp = vehicleTyp;
        }
        
        public override void MakeSound()
        {
            Console.WriteLine($"Hi, I'm a {VehicleColor} car and I will make no sound");
        }


        public override void PresentVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"Color: {vehicle.VehicleColor} Type: {vehicle.VehicleTyp}");
            MakeSound();
        }

        

    }
}
