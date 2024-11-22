using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using Laboratory5C_2._0;

class Program
{
    static void Main(string[] args)
    {
        Helicopter helicopter = new Helicopter("Kamov", "Ka-52", 2020, 2, 5500, HelicopterPurpose.Военный, FuelType.Бензин);
        Truck civilianTruck = new Truck("MAN", "TGS", 2021, FuelType.Дизель, 6, CarType.Седан, 25000, TruckType.Гражданский);
        Truck quarryTruck = new Truck("Caterpillar", "773G", 2019, FuelType.Дизель, 8, CarType.Седан, 50000, TruckType.Карьерный);
        PassengerCar raceCar = new PassengerCar("Ferrari", "F8", 2023, FuelType.Бензин, 4, CarType.Седан, PassengerCarType.Гоночный);
        PassengerCar familyCar = new PassengerCar("Toyota", "Corolla", 2020, FuelType.Бензин, 4, CarType.Седан, PassengerCarType.Семейный);
        PassengerCar governmentCar = new PassengerCar("Mercedes", "S-Class", 2021, FuelType.Дизель, 4, CarType.Седан, PassengerCarType.Государственный);

        TechVehicle[] vehicles = new TechVehicle[]
        {
            helicopter,
            civilianTruck,
            quarryTruck,
            raceCar,
            familyCar,
            governmentCar
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Name);
            vehicle.DrawObject();
            Console.WriteLine();
        }
    }
}

