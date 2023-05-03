using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pervoe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Дано проміжок від а до b");
             Console.WriteLine("Введіть число а: ");
               a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть число b: ");
                  b = int.Parse(Console.ReadLine());
                   Console.WriteLine("Введіть число c: ");
                    c = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % c == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
