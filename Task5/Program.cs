using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of all numbers from 1 to {number} equals to {sum}");
            Console.ReadLine();
        }
    }
}
