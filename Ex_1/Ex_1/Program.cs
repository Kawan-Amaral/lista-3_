using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
        do {
            Console.Write("Digite um valor positivo: ");
            valor1 = double.Parse(Console.ReadLine());
        } while (valor1 <= 0);
        }
    }
}
