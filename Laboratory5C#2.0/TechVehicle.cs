using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5C_2._0
{
    public class TechVehicle : ICalculate, IVisual
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public FuelType FuelType { get; set; }
        public VehicleCategory VehicleCategory { get; set; }

        public virtual string Name { get; set; }

        public TechVehicle(string manufacturer, string model, int year, FuelType fuelType, VehicleCategory vehicleCategory)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            FuelType = fuelType;
            VehicleCategory = vehicleCategory;
        }

        public virtual void Plus(int value)
        {
            Console.WriteLine($"Увеличено на {value}");
        }

        public virtual void Minus(int value)
        {
            Console.WriteLine($"Уменьшено на {value}");
        }

        public virtual void DrawObject() { }
    }
}
