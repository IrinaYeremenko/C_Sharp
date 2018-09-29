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
            double p1, p2, n1, n2, s, r;

            Console.WriteLine("Product price 1:");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Product price 2:");
            p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Product number 1:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Product number 2:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum of your money:");
            s = Convert.ToDouble(Console.ReadLine());
            r = s - ((p1 * n1) + (p2 * n2));

            if (r > 0)
            {
                Console.WriteLine("Your change: " + r);
            }
            else if (r < 0)
            {
                Console.WriteLine("You don't have enough money");
            }
            else
            {
                Console.WriteLine("Exact change");
            }

        }
    }
}
