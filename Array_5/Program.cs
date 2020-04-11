using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];

            Console.WriteLine($"Fill the array with {lenght} numbers.");
            for (int i = 0; i < lenght; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("End of filling");
            Console.WriteLine($"This is your array {string.Join(", ", array)}");

            
        }
    }
}
