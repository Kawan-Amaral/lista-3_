using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            do
            {
                int numero;
                do
                {
                    Console.Write("Digite um número inteiro não negativo para calcular o fatorial: ");
                    numero = int.Parse(Console.ReadLine());
                } while (numero < 0);

                long fatorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    fatorial *= i;
                }

                Console.WriteLine($"{numero}! = {fatorial}");

                do
                {
                    Console.Write("Deseja calcular outro fatorial? (S/N): ");
                    resposta = Console.ReadLine().ToUpper();
                } while (resposta != "S" && resposta != "N");

            } while (resposta == "S");
        }
    }
}
    

