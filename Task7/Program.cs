using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input width");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input height");
            int height = Convert.ToInt32(Console.ReadLine());

            while (height > 0)
            {
                string result = "";
                for (int i = 1; i < width; i++)
                {
                    result += "*";
                }
                Console.WriteLine(result);
                height--;
            }

            Console.ReadLine();
        }
    }
}
