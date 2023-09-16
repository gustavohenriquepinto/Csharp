using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    partial class Pessoa
    {
        public void Apresentar()
        {
            Console.WriteLine("Olá, eu sou " + nome);
        }

        public static int CalcularIdade(int anoDeNascimento)
        {
            return DateTime.Now.Year - anoDeNascimento;
        }
    }
}
