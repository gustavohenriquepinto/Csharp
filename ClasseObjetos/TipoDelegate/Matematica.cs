﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    internal class Matematica
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine("Resultado da soma: "+ (n1 + n2));
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("Resultado da subtração: " + (n1 - n2));
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine("Resultado da multiplicação: " + (n1 * n2));
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine("Resultado da divisão: " + (n1 / n2));
        }
    }
}
