using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue, soma10 = 0, entrada;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.Write($"Digite o {i + 1}º valor positivo: ");
                    entrada = int.Parse(Console.ReadLine());
                } while (entrada <= 0);
                if (entrada > maior) maior = entrada;
                soma10 += entrada;
            }
            Console.WriteLine($"Maior valor: {maior}");
            Console.WriteLine($"Soma: {soma10}");
            Console.WriteLine($"Média: {(double)soma10 / 10:F2}");

        }
    }
}
