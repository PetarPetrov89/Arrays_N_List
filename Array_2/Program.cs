using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();
        }
    }
}
