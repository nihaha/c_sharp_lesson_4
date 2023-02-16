using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i <= number) 
            {
                Console.WriteLine($"3 * {i} = {3 * i}");
                i++;
            }

            Console.ReadLine();
        }
    }
}
