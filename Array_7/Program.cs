using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете число");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Въведете стойност на масива");

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;

            for (int i = 0; i < n / 2; i++)
            {
                if (array[i] != array[n - 1- i])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine($"Симетричен ли е масива? {symmetric}");
        }
    }
}
