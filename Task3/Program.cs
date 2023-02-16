using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Напишите программу, в которой даны натуральные числа от 20 до 50. Вывести на консоль те из 
 * них, которые делятся на 3, но не делятся на 5.
 */
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rangeStart = 20;
            int rangeEnd = 50;

            while (rangeStart <= rangeEnd) 
            {
                if (rangeStart % 3 == 0 && rangeStart % 5 != 0)
                {
                    Console.WriteLine(rangeStart);
                }
                rangeStart++;
            }
            Console.ReadLine();
        }
    }
}
