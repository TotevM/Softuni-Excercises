﻿namespace NeedForSpeed;

internal class SportCar : Car
{
    public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
    {
        HorsePower = horsePower;
        Fuel = fuel;
    }

    public int HorsePower { get; set; }
    public double Fuel { get; set; }
    public double DefaultFuelConsumption { get; set; }
    public override double FuelConsumption => 10;

    public override void Drive(double km)
    {
        Fuel -= km * FuelConsumption;
    }
}
