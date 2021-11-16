using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class MyArray
    {
        public int[] FillArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Input value: ");
                int value = Convert.ToInt32(Console.ReadLine());
                arr[i] += value;
            }
            return arr;
        }
        public int[] SortArray(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
        public int[] ShowArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            return arr;
        }
    }
}
