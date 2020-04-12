using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 1,3,5,6,7};
            
            numberList.Add(2);
            numberList.Remove(3);
            Console.WriteLine(numberList.IndexOf(22));

        }
    }
}
