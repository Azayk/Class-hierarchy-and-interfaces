using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5C_2._0
{
    public class Helicopter : TechVehicle
    {
        public int Blades { get; set; }
        public int FlightRange { get; set; }
        public HelicopterPurpose Purpose { get; set; }

        public Helicopter(string manufacturer, string model, int year, int blades, int flightRange, HelicopterPurpose purpose, FuelType fuelType)
            : base(manufacturer, model, year, fuelType, VehicleCategory.Воздушный)
        {
            Blades = blades;
            FlightRange = flightRange;
            Purpose = purpose;
        }

        public override string Name
        {
            get { return $"{Model} ({Manufacturer}, {Year}) - {Purpose}"; }
            set { Model = value; }
        }

        public override void DrawObject()
        {
            base.DrawObject();
            Console.WriteLine($"Количество лопастей: {Blades}");
            Console.WriteLine($"Дальность полета: {FlightRange} км");
            Console.WriteLine($"Назначение: {Purpose}");

            Console.WriteLine("         _");
            Console.WriteLine("    -=\\`\\");
            Console.WriteLine(" |-\\ ___|___");
            Console.WriteLine("     o   o");
        }
    }

}
