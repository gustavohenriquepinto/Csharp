using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjetos
{
    internal class Pessoa
    {
        public string nome, sobrenome;
        public int anoDeNascimento;

        public void Cumprimentar()
        {
            Console.WriteLine("Olá, meu nome é "+nome+" "+sobrenome+" e nasci em "+anoDeNascimento);
        }

    }
}
