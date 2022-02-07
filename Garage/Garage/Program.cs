using System;
using System.Collections.Generic;
using System.Linq;
using Garage;
using System.Text.Json;


namespace Garage
{
    public static class Program
    {
        
        public static void Main(string[] args)
        {
            //Car car = new Car("Seat", 1982);
            Garage garage = new Garage("Default", 0);
            Truck truck = new Truck("ciezarowy", "zielony");

            


            Console.WriteLine($"Hello!\nWelcome in \"GARAGE BUILDER\".In this program you can build a garage with maximum five parking spaces.\n" +
                              $"Then create Cars that will be there\n.");
            Console.WriteLine("Garage name:");
            string? userInput = String.Empty;
            userInput = Console.ReadLine();
            ;
            while (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Write your garage name.");
                userInput = Console.ReadLine();
                garage.GarageName = userInput;

            }

            
            Console.WriteLine($"Set the size of the garage (max 5)");
            
            userInput = Console.ReadLine();
            int result = 0;
            do
            {
                if (int.TryParse(userInput, out result))
                {
                    Console.WriteLine($"Your garage have {result} free spaces.");
                    
                    garage.PlacesNumber = result;
                    
                }
                if (result < 1 || result > 5)
                {
                    Console.WriteLine("Max garage capacity is 5.");
                    userInput = Console.ReadLine();
                }
                
            } while (result < 1 || result > 5);

            
            List<Vehicle> vehicles = garage.AddVehicle(garage.PlacesNumber);
            
            garage.PresentAllVehicle(vehicles);

            string json = JsonSerializer.Serialize(vehicles);

            File.WriteAllText(@".\vehicles.json", json);








        }
    }
}

