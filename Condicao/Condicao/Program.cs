using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simples e Encadeadas
            //byte n1 = 3;

            //if (n1 >3)
            //{
            //    Console.WriteLine("Condição Verdadeira");
            //}
            //else if (n1 <= 2)
            //{
            //    Console.WriteLine("Condição Falsa");
            //}
            //else
            //{
            //    Console.WriteLine("Número não existe");
            //}
            #endregion

            #region Aninhadas
            //int n1 = 3;

            //if (n1 > 0)
            //{
            //    Console.Write("O número é positivo");
            //    if(n1%2 == 0)
            //    {
            //        Console.WriteLine(" e par");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" e ímpar");
            //    }
            //}
            #endregion

            #region Operador Ternário
            //int num = 3;

            //Console.WriteLine(num > 5 ? "Maior que 5" : "Menor ou igual a 5");
            #endregion

            Console.WriteLine("Informe seu peso em quilogramas");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura em metros");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 20)
            {
                Console.WriteLine("\nVocê está abaixo do peso, seu IMC é de " + imc);
            }
            else if(imc < 24)
            {
                Console.WriteLine("\nVocê está com o peso normal, seu IMC é de " + imc);
            }
            else if (imc < 29)
            {
                Console.WriteLine("\nVocê está acima do peso, seu IMC é de " + imc);
            }
            else if (imc < 34)
            {
                Console.WriteLine("\nVocê está obeso, seu IMC é de " + imc);
            }
            else
            {
                Console.WriteLine("\nVocê está muito obeso, seu IMC é de " + imc);
            }

        }
    }
}
