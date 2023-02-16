using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money does Peter have, $?");
            double money = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much does one ice cream cots, $?");
            double price = Convert.ToDouble(Console.ReadLine());

            int amount = 0;

            while (money >= price)
            {
                amount++;
                money -= price;
            }

            Console.WriteLine($"Peter can buy {amount} ice creams.");
            Console.WriteLine($"Peter has ${money}.");
            Console.ReadLine();
        }
    }
}
