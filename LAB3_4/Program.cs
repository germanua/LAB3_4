namespace LAB3_4;

class Program
{
    static void Main()
    {
        Car myCar = new Car();

        // Subscribe to events
        myCar.RunningOutOfGasoline += (sender, e) =>
        {
            Console.WriteLine($"RunningOutOfGasoline Event: {e.Message}");
        };

        myCar.Refueled += (sender, message) =>
        {
            Console.WriteLine($"Refueled Event: {message}");
        };

        // Start moving
        myCar.StartMoving();
    }
}