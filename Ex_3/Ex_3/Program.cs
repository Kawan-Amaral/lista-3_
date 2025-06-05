using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            do
            {
                Console.Write("Digite o sexo (F ou M): ");
                sexo = Console.ReadLine().ToUpper();
            } while (sexo != "F" && sexo != "M");

        }
    }
}
