using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int t = 1; t <= 20; t++)
            {
                Console.WriteLine($"Tabuada do {t}:");
                for (int i = 1; i <= 10; i++)
                    Console.WriteLine($"{t} x {i} = {t * i}");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
