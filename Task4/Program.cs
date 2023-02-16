using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** NOTE: your income will be calculated based on annual percantage ***");
            Console.WriteLine("");

            Console.WriteLine("Please, input amount of deposit money, $");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, input percentage, %");
            double percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please, input duration, months");
            double duration = Convert.ToDouble(Console.ReadLine());

            double percentPerMonth = percent / 12;
            double income = percentPerMonth * duration / 100 * deposit;

            Console.Write("");
            Console.WriteLine($"Your income equals to ${income}");
            Console.WriteLine($"Your total profit is ${income + deposit}");

            Console.ReadLine();
        }
    }
}
