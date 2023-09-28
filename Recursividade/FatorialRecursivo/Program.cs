using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual fatorial você quer calcular? ");
            int calcular = int.Parse(Console.ReadLine());

            long fatorial = Fatorial(calcular);

            if(fatorial == 0)
            {
                Console.WriteLine("\nVocê digitou um número inválido.");
            }
            else
            {
                Console.WriteLine("\nO resultado é: " + fatorial);
            }

            Console.ReadKey();

        }

        static long Fatorial(int numero)
        {
            if (numero > 1)
            {
                return numero * Fatorial(numero - 1);
            }
            else if (numero >= 0)
            {
                return 1;
            }
            return 0;
            
        }
    }
}
