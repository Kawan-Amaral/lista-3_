using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a2, b2;
            do
            {
                Console.Write("Digite o valor de X: ");
                x = int.Parse(Console.ReadLine());
            } while (x <= 0);

            do
            {
                Console.Write("Digite o valor de A: ");
                a2 = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de B (maior que A): ");
                b2 = int.Parse(Console.ReadLine());
            } while (b2 <= a2);

            for (int i = b2; i >= a2; i--)
                Console.WriteLine($"{x} x {i} = {x * i}");
        }
    }
}
