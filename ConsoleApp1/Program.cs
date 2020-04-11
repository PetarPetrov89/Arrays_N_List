using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello in shop");

            List<string> products = new List<string>() { "домат", "краставица", "банан", "киви", "круша" };

            //Console.WriteLine("Колко неща ще си купите?");
            Console.WriteLine($"Нашите продукти са: {string.Join(", ", products)}");
            List<string> shoppingCart = new List<string>();

            string product = Console.ReadLine();

            while (product != "стоп")
            {
                if (!products.Contains(product))
                {
                    Console.WriteLine("Няма такъв продукт");
                    product = Console.ReadLine();
                    continue;
                }
                shoppingCart.Add(product);

                product = Console.ReadLine();
            }

            if (shoppingCart.Any(p => p == "банан"))
            {
                Console.WriteLine("Имаш нещо здравословно в кошницата");
            }

            Console.WriteLine(string.Join(", ", shoppingCart));

        }

        public static void ChangeList(List<int> list)
        {
            list.Add(3);
        }

        public static void ChangeInt(int a)
        {
            a = 5;
        }

        public static void ChangString(string a)
        {
            a = "Changed";
        }
    }
}

