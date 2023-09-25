using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:

            Console.Write("Quantos elementos tem a sequência? ");
            byte quantidade = byte.Parse(Console.ReadLine());

            long[] fibonacci = new long[quantidade];
            Console.WriteLine();

            if (quantidade < 1)
            {
                Console.WriteLine("A sequência não possui elementos.");
            }
            else if (quantidade > 92)
            {
                Console.WriteLine("O limite é de 92 elementos.");
            }
            else
            {
                fibonacci[0] = 1;

                for(int i = 0; i < quantidade; i++)
                {
                    if (i == quantidade - 1)
                    {
                        Console.Write("[" + fibonacci[i] + "].\n");
                    }
                    else
                    {                    
                    Console.Write("[" + fibonacci[i] + "], ");
                        
                    fibonacci[i + 1] = i == 0 ? fibonacci[i] : fibonacci[i] + fibonacci[i - 1];
                    }

                }
            }

            Console.Write("\nDe novo? (S/N): ");
            string inicio = Console.ReadLine();
            if (inicio == "S" || inicio == "s")
            {
                Console.WriteLine();
                goto Inicio;
            }
        }
    }
}
