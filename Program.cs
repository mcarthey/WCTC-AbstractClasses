using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.Start();
            ford.Drive();
            ford.ShowColor();

            Dodge dodge = new Dodge();
            dodge.Start();
            dodge.Drive();
            dodge.ShowColor();

            // polymorphism
            Vehicle f1 = new Ford();
            f1.ShowColor();
            Vehicle d1 = new Dodge();
            d1.ShowColor();

        
        }
    }
}
