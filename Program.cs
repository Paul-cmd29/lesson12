using System;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Vehicle car = new Vehicle("Ford");
            VehicleModel CarModel = new VehicleModel("Ford","Mustang");

            car.Print();
            CarModel.Print();

            Wheel a = new Wheel(4);
            TypeOfCar b = new TypeOfCar(4, "");
            a.Print();
            b.Print();


            Engine CarEngine = new Engine(3.5);
            EngineClass CarEnginFull = new EngineClass("V-6", 3.5);
            CarEngine.Print();
            CarEnginFull.Print();
        }

    }
}

