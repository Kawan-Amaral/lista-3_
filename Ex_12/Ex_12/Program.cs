using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repetir;
            do
            {
                int n;
                do
                {
                    Console.Write("Digite a quantidade de valores (entre 1 e 19): ");
                    n = int.Parse(Console.ReadLine());
                } while (n <= 0 || n >= 20);

                int maior = int.MinValue, menor = int.MaxValue, soma = 0, positivos = 0, negativos = 0;

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Valor {i + 1}: ");
                    int valor = int.Parse(Console.ReadLine());

                    if (valor > maior) maior = valor;
                    if (valor < menor) menor = valor;
                    soma += valor;
                    if (valor > 0) positivos++;
                    else if (valor < 0) negativos++;
                }

                double media = (double)soma / n;
                double percPositivos = (double)positivos / n * 100;
                double percNegativos = (double)negativos / n * 100;

                Console.WriteLine($"Maior valor: {maior}");
                Console.WriteLine($"Menor valor: {menor}");
                Console.WriteLine($"Soma: {soma}");
                Console.WriteLine($"Média: {media:F2}");
                Console.WriteLine($"% de positivos: {percPositivos:F2}%");
                Console.WriteLine($"% de negativos: {percNegativos:F2}%");

                do
                {
                    Console.Write("Deseja repetir a operação? (S/N): ");
                    repetir = Console.ReadLine().ToUpper();
                } while (repetir != "S" && repetir != "N");

            } while (repetir == "S");
        }
    }

}
    

