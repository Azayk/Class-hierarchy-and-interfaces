using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5C_2._0
{
    public class PassengerCar : Car
{
    public PassengerCarType PassengerCarType { get; set; }

    public PassengerCar(string manufacturer, string model, int year, FuelType fuelType, int wheels, CarType carType, PassengerCarType passengerCarType)
        : base(manufacturer, model, year, fuelType, wheels, carType)
    {
        PassengerCarType = passengerCarType;
    }

    public override string Name
    {
        get { return $"{Model} ({Manufacturer}, {Year})"; }
        set { Model = value; }
    }

    public override void DrawObject()
    {
        base.DrawObject();
        Console.WriteLine($"Тип легкового автомобиля: {PassengerCarType}");
        
        switch (PassengerCarType)
        {
            case PassengerCarType.Гоночный:
                Console.WriteLine("      _______");
                Console.WriteLine("   __/|__|__\\___");
                Console.WriteLine("  | O | O | O |");
                Console.WriteLine("  --------------");
                break;

            case PassengerCarType.Семейный:
                Console.WriteLine("      ______");
                Console.WriteLine("  ___/______\\___");
                Console.WriteLine(" |   O      O   |");
                Console.WriteLine(" ----------------");
                break;

            case PassengerCarType.Государственный:
                Console.WriteLine("      ______");
                Console.WriteLine("  ___/______\\___");
                Console.WriteLine(" | [*]  [*]  |");
                Console.WriteLine("  ------------");
                break;

            default:
                Console.WriteLine("Тип не определен.");
                break;
        }
    }
}

}
