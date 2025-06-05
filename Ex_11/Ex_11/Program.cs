using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Quantos valores deseja digitar (1 a 19): ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n >= 20);

            int maior11 = int.MinValue, menor11 = int.MaxValue, soma11 = 0, pos = 0, neg = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                int v = int.Parse(Console.ReadLine());
                if (v > maior11) maior11 = v;
                if (v < menor11) menor11 = v;
                soma11 += v;
                if (v > 0) pos++;
                else if (v < 0) neg++;
            }
            Console.WriteLine($"Maior: {maior11}, Menor: {menor11}, Soma: {soma11}, Média: {(double)soma11 / n:F2}");
            Console.WriteLine($"% Positivos: {(double)pos / n * 100:F2}%");
            Console.WriteLine($"% Negativos: {(double)neg / n * 100:F2}%");
        }
    }
}
