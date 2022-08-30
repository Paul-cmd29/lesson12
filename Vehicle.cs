using System;
namespace lesson12
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public Vehicle(string Brand)
        {
            this.Brand = Brand;
        }

    

        public virtual void Print()
        {
            Console.WriteLine(Brand);
        }
    }

    public class VehicleModel : Vehicle
    {
        public string Model { get; set; }
        public VehicleModel(string Brand, string Model) : base(Brand)
        {
            this.Model = Model;
        }

        public override void Print()
        {
            Console.WriteLine($"Brand name:{Brand} model:{Model}");
        }
    }
}

