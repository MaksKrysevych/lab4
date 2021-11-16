using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        public delegate int[] Func(int[] arr);
        static void Main(string[] args)
        {
            Menu();
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Events events = new Events();
                        Console.WriteLine("Kilometers: ");
                        double kilometers = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Spending of fuel: ");
                        double spendingOfFuel = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Fuel left:");
                        double fuel = Convert.ToDouble(Console.ReadLine());


                        Car car = new Car(spendingOfFuel, fuel, kilometers);
                        car.StartRunning += events.Car_StartRunning;
                        car.Running += events.Car_Running;
                        car.FinishRunning += events.Car_FinishRunning;
                        car.WarningOfFuel += events.Car_WarningOfFuel;
                        car.FuelLeft += events.Car_FuelLeft;
                        car.FillFuel += events.FillFuel;

                        car.CalcFuel();
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        MyArray myArray = new MyArray();
                        
                        Console.WriteLine("Input size of array:");
                        int size = Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[size];
                        
                        Func<int [], int[]> func = myArray.FillArray;
                        func += myArray.SortArray;
                        func += myArray.ShowArray;
                        func(arr);
                        
                        Console.ReadLine();
                        break;
                    }
                default:
                    break;
            }
        }
        public static void Menu()
        {
            Console.WriteLine("Main menu:");
            Console.WriteLine("1. Work with car");
            Console.WriteLine("2. Work with delegate");
            Console.WriteLine("3. Close");

        }
        
    }
}
