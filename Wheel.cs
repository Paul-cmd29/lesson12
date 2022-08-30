using System;
namespace lesson12
{
    public class Wheel
    {
        public int wheel { get; set; }
        public Wheel(int AmountOfWheel)
        {
            wheel = AmountOfWheel;
        }

        public virtual void Print()
        {
            Console.WriteLine(wheel);
        }
    }

    public class TypeOfCar : Wheel
    {
       

        public string type { get; set; }

        public TypeOfCar(int AmountOfWheel, string type) : base(AmountOfWheel)
        {
            this.type = type;
            AmountOfWheel = wheel;
           
        }

        public override void Print()
        {
            if (wheel < 3)
            {
                Console.WriteLine("Motorcycle");
            }
            else if (wheel > 3)
            {
                Console.WriteLine("Car");
            }
            else
            {
                Console.WriteLine("Something went wrong:(");
            }
        }
    }
}

