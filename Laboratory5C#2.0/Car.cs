using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5C_2._0
{
    public class Car : TechVehicle
    {
        public int Wheels { get; set; }
        public CarType CarType { get; set; }

        public Car(string manufacturer, string model, int year, FuelType fuelType, int wheels, CarType carType)
            : base(manufacturer, model, year, fuelType, VehicleCategory.Легковой)
        {
            Wheels = wheels;
            CarType = carType;
        }

        public override string Name
        {
            get { return $"{Model} ({Manufacturer}, {Year})"; }
            set { Model = value; }
        }

        public override void DrawObject()
        {
            base.DrawObject();
            Console.WriteLine($"Тип автомобиля: {CarType}");
            Console.WriteLine($"Количество колес: {Wheels}");
        }
    }


}
