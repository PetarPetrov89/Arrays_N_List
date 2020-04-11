using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int lenght = numbers.Length;

            int[] reserved = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                reserved[lenght - 1 - i] = numbers[i];
            }
            Console.WriteLine(string.Join(", ", reserved));
        }
    }
}
