using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //Class1 outra = new Class1();
            //Class1 outra2 = outra;
            #endregion

            #region Atributos
            Pessoa p1 = new Pessoa();
            p1.nome = "Gustavo";
            p1.sobrenome = "Pinto";
            p1.anoDeNascimento = 2004;

            Pessoa p2 = new Pessoa()
            {
                nome = "Edvaldo",
                sobrenome = "Pereira",
                anoDeNascimento = 1950
            };

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoDeNascimento);
            p1.Cumprimentar();

            Console.WriteLine("\nPessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoDeNascimento);
            p2.Cumprimentar();
            #endregion






        }
    }

    class MinhaClasse
    {
        //Console.WriteLine("Olá, mundo!");
    }
}
