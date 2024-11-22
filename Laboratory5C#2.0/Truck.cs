using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5C_2._0
{
    public class Truck : Car
    {
        public int LoadCapacity { get; set; }
        public TruckType TruckType { get; set; }

        public Truck(string manufacturer, string model, int year, FuelType fuelType, int wheels, CarType carType, int loadCapacity, TruckType truckType)
            : base(manufacturer, model, year, fuelType, wheels, carType)
        {
            LoadCapacity = loadCapacity;
            TruckType = truckType;
        }

        public override string Name
        {
            get { return $"{Model} ({Manufacturer}, {Year}) - {TruckType}"; }
            set { Model = value; }
        }

        public override void DrawObject()
        {
            base.DrawObject();
            Console.WriteLine($"Грузоподъемность: {LoadCapacity} кг");
            Console.WriteLine($"Тип грузовика: {TruckType}");

            switch (TruckType)
            {
                case TruckType.Гражданский:
                    Console.WriteLine("      ________");
                    Console.WriteLine(" ____/        \\____");
                    Console.WriteLine("| [][][][][][][][][] |");
                    Console.WriteLine(" ----------------------");
                    break;

                case TruckType.Карьерный:
                    Console.WriteLine("        _________");
                    Console.WriteLine("       /         \\");
                    Console.WriteLine("   ____|_________|____");
                    Console.WriteLine("  |       [][][][]     |");
                    Console.WriteLine("   ---------------------");
                    break;

                default:
                    Console.WriteLine("Тип грузовика не определен.");
                    break;
            }
        }
    }

}
