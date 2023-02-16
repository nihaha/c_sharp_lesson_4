using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of elements");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fibonacci sequence: ");
            int first_element = 0; 
            int second_element = 1;

            string result = "";

            if (number >= 0)
            {
                if (number == 1)
                {
                    result += Convert.ToString(first_element);
                }
                else if (number == 2)
                {
                    result += Convert.ToString(first_element + ", " + second_element);
                }
                else
                {
                    result += Convert.ToString(first_element + ", " + second_element + ", ");

                    for (int i = 3; i <= number; i++)
                    {
                        result += Convert.ToString(first_element + second_element) + ", ";
                        (first_element, second_element) = (second_element, first_element + second_element);
                    }
                }

                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
