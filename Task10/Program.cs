using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Напишите программу, которая будет складывать, вычитать, умножать или делить два числа. 
 * Числа и знак операции вводятся пользователем. После выполнения вычисления программа не 
 * должна завершаться, а должна запрашивать новые данные для вычислений. Завершение 
 * программы должно выполняться при вводе символа '0' в качестве знака операции. Если 
 * пользователь вводит неверный знак (не '0', '+', '-', '*', '/'), то программа должна сообщать ему об 
 * ошибке и снова запрашивать знак операции. Также сообщать пользователю о невозможности 
 * деления на ноль, если он ввел 0 в качестве делителя.
 */
namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers and operation sign");

            while(true)
            {
                Console.WriteLine("First number:");
                double num_1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Second number:");
                double num_2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                while (true)
                {
                    Console.WriteLine("Operation:");
                    string sign = Console.ReadLine();

                    switch (sign)
                    {
                        case "+":
                            result = num_1 + num_2;
                            break;
                        case "-":
                            result = num_1 - num_2;
                            break;
                        case "*":
                            result = num_1 * num_2;
                            break;
                        case "/":
                            if (num_2 != 0)
                            {
                                result = num_1 / num_2;
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"You can not divide by 0!\n");
                                continue;
                            }
                        case "0":
                            Console.WriteLine($"Program will exit\n");
                            Console.ReadLine();
                            System.Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine($"Wrong operation sign: {sign}\n");
                            continue;
                    }

                    break;
                }

                Console.WriteLine($"Result: {result}\n");
            }            
        }
    }
}
