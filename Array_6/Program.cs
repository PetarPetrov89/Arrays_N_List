using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(string.Join(", ", numbers));

            numbers[0] = 10;

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
