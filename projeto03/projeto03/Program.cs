using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Esse quebra a linha");
            //Console.Write("Esse não vai quebrar a linha.");

            //Console.Read();
            //Console.ReadKey(); //Retorna o código da primeira letra em valor inteiro
            Console.WriteLine("Qual é seu nome?");
            string nome = Console.ReadLine(); //Retorna o texto digitado em string
            Console.WriteLine("Olá, " + nome);
            

        }
    }
}
