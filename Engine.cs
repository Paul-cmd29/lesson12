using System;
namespace lesson12
{
    public class Engine
    {
        public double TypeOfEngine { get; set; }
        public Engine(double TypeOfEngine)
        {
            this.TypeOfEngine = TypeOfEngine;
        }
        public virtual void Print()
        {
            Console.WriteLine($"This car have {TypeOfEngine} liters engine"); 
        }
    }
    public class EngineClass : Engine
    {
        public string Engine { get; set; }
        public EngineClass(string Engine, double TypeOfEngine) : base(TypeOfEngine)
        {
            this.Engine = Engine;
        }

        public override void Print()
        {
            Console.WriteLine($"This car have {TypeOfEngine} liters engine {Engine}");

        }
    }
}

