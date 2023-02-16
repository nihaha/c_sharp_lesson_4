using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Напишите программу, которая будет выводить на экран числа от 1 до 5. Написать три варианта 
 * реализации (while, do...while, for).
 */
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop using `while`");
            int num = 1;
            while (num <= 5)
{
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("Loop using `do ... while`");
            num = 1;
            do 
            { 
                Console.WriteLine(num);
                num++;
            } 
            while (num <= 5);

            Console.WriteLine("Loop using `for`");            
            for (num = 1; num <= 5; num++)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
