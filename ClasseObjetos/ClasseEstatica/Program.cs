﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Estática

            //Matematica.taxa = 10;

            //int valor1 = Matematica.Adicionar(100);
            //int valor2 = Matematica.Diminuir(100);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);

            #endregion

            Pessoa.maioridade = 21;
            Pessoa p1 = new Pessoa();

            p1.nome = "Gustavo";
            p1.idade = Pessoa.CalcularIdade(2004);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);

            Console.ReadKey();
        }
    }
}
