namespace AbstractClasses
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public abstract void Drive();
        public virtual void ShowColor() {}

        // 1. Create a new abstract method (require implementation)
        // 2. Create a new virtual method (optional implementation)
        // Implement in two of your concrete classes

        public virtual void Start() 
        {
            System.Console.WriteLine("The vehicle has started");
        }

        public void Stop() 
        {
            System.Console.WriteLine("The vehicle is stopped");
        }

    }
}