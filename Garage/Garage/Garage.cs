using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using System.Text.Json;
namespace Garage
{
     class Garage 
    {
        
        public  string GarageName {get; set; }
        public int PlacesNumber { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public Garage(string garageName, int placesNumber)
        {
            this.GarageName = garageName;
            this.PlacesNumber = placesNumber;
            this.Vehicles = new List<Vehicle>();
        }

        public List<Vehicle> AddVehicle(int garageSpace)
        {
            for (int i = 0; i < garageSpace; i++)
            {
                Console.WriteLine("Vehicle Typ:\nT - Truck,\nM - Motorbike,\nB - Bus,\nC - Car.");
                string inputVehicle = Console.ReadLine();
                while (String.IsNullOrWhiteSpace(inputVehicle))
                {
                    Console.WriteLine("Enter vehicle Typ");
                    inputVehicle = Console.ReadLine();
                    inputVehicle = inputVehicle.ToUpper();

                }
                
                inputVehicle = inputVehicle.ToUpper();

                Console.WriteLine("Enter color:");
                string color = Console.ReadLine();


                if (inputVehicle == "T")                              //uzupełnić typ, sprawdzić ARGUMENTY
                {
                    Vehicle vehicle = new Truck("Truck", color);
                    Vehicles.Add(vehicle);
                }
                if (inputVehicle == "M")
                {
                    Vehicle vehicle = new Motorbike("Motorbike", color);
                    Vehicles.Add(vehicle);
                }
                if (inputVehicle == "B")
                {
                    Vehicle vehicle = new Bus("Bus", color);
                    Vehicles.Add(vehicle);
                }
                if (inputVehicle == "C")
                {
                    Vehicle vehicle = new Car("Car",color );
                    Vehicles.Add(vehicle);
                }
            }
            
            return Vehicles;
        }

        public void PresentAllVehicle(List<Vehicle> vehicles)
        {
            
            foreach (var vehicle in vehicles)
            {
                vehicle.PresentVehicle(vehicle);
                Thread.Sleep(2000);
            }
            

        }

        
    }
    
}
