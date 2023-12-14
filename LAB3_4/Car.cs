namespace LAB3_4;

public class Car
{
    public event EventHandler<GasolineEmptyEventArgs> RunningOutOfGasoline;
    public event EventHandler<string> Refueled;

    private int fuelLevel = 100;

    public void StartMoving()
    {
        Console.WriteLine("Started moving.");
        ConsumeFuel(10);
        ConsumeFuel(20);
        ConsumeFuel(20);
        ConsumeFuel(20);
        Console.WriteLine("Stopped moving.");

        // Refuel if the fuel level is below 30
        if (fuelLevel <= 30)
        {
            Refuel();
        }
        // Simulate more fuel consumption
        ConsumeFuel(20);
        ConsumeFuel(40); 
    }

    private void ConsumeFuel(int fuelConsumption)
    {
        fuelLevel -= fuelConsumption;

        if (IsRunningOutOfGasoline())
        {
            OnRunningOutOfGasoline();
        }

        Console.WriteLine($"Fuel level: {fuelLevel}");
    }

    private bool IsRunningOutOfGasoline()
    {
        return fuelLevel <= 0;
    }

    protected virtual void OnRunningOutOfGasoline()
    {
        RunningOutOfGasoline?.Invoke(this, new GasolineEmptyEventArgs("Car is running out of gasoline!"));
    }

    private void Refuel()
    {
        int refuelAmount = 60 - fuelLevel;
        fuelLevel = 60;

        Console.WriteLine($"Refueled to {fuelLevel}");
    }

    // Getter for fuelLevel
    public int GetFuelLevel()
    {
        return fuelLevel;
    }
}