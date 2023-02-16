using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            int num_a = Convert.ToInt32(Console.ReadLine());
            int first_num = num_a;

            Console.WriteLine("Input second number");
            int num_b = Convert.ToInt32(Console.ReadLine());

            if (num_a > num_b)
            {
                Console.WriteLine("First number should be lower than second");
                Console.ReadLine();

                System.Environment.Exit(1);
            }

            int result = 0;
            string odd_numbers = "";

            while (num_a <= num_b)
            {
                result += num_a;
                if (num_a % 2 != 0)
                {
                    odd_numbers += Convert.ToString(num_a + ", ");
                }
                num_a++;
            }

            Console.WriteLine($"Total sum of all numbers between {first_num} and {num_b} equals to {result}");
            Console.WriteLine($"All odd numbers between are {odd_numbers}");
            Console.ReadLine();
        }
    }
}
