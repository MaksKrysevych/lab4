using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Events
    {
        

        public void Car_StartRunning()
        {
            Console.WriteLine("Car start running.");
        }
        public void Car_Running()
        {
            Console.WriteLine("Car is running.");
        }
        public void Car_FinishRunning()
        {
            Console.WriteLine("Car finish running.");
        }
        public void Car_WarningOfFuel()
        {
            Console.WriteLine("Fuel left less than 10 liters!");
            Console.WriteLine("Go to gas station!");
        }
        public void FillFuel()
        {
            Console.WriteLine("Filling fuel...");
        }
        public void Car_FuelLeft()
        {
            Console.WriteLine("Fuel left!");
        }
    }
}
