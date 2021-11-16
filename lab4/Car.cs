using System;

namespace lab4
{
    public class Car
    {
        double SpendingOfFuel;
        double Fuel;
        double Kilometers;
        public event Action Running;
        public event Action WarningOfFuel;
        public event Action FuelLeft;
        public event Action StartRunning;
        public event Action FinishRunning;
        public event Action FillFuel;

        public Car(double spendingOfFuel, double fuel, double kilometers)
        {
            SpendingOfFuel = spendingOfFuel;
            Fuel = fuel;
            Kilometers = kilometers;
        }

        public void CalcFuel()
        {
            StartRunning.Invoke();

            while (Kilometers != 0 && Fuel != 0)
            {
                double spendingOfFuelFor1km = SpendingOfFuel / 100;
                if (Fuel < 10)
                {
                    WarningOfFuel.Invoke();

                    Console.WriteLine("Fill fuel?(y/n)");
                    string desicion = Console.ReadLine();
                    if (desicion == "y")
                    {
                        Console.WriteLine("How much liters fill?");
                        double liters = Convert.ToDouble(Console.ReadLine());
                        Fuel += liters;
                        FillFuel.Invoke();
                    }
                    if (Fuel == 0)
                    {
                        FuelLeft.Invoke();
                        FinishRunning.Invoke();
                        break;
                    }
                }
                if (Fuel == 0)
                {
                    FuelLeft.Invoke();
                }

                Fuel -= spendingOfFuelFor1km;
                Kilometers--;
            }
            if (Fuel == 0)
            {
                FuelLeft.Invoke();
            }
            FinishRunning.Invoke();

        }
    }
}
