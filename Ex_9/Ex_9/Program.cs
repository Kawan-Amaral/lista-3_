using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fib1 = 1, fib2 = 1, fibNext;
            Console.Write("Série de Fibonacci: 1, 1");
            for (int i = 3; i <= 30; i++)
            {
                fibNext = fib1 + fib2;
                Console.Write($", {fibNext}");
                fib1 = fib2;
                fib2 = fibNext;
            }
            Console.WriteLine();
        }
    }
}
