using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite o segundo valor (maior que o primeiro): ");
                b = int.Parse(Console.ReadLine());
            } while (b <= a);
        }
    }
}
