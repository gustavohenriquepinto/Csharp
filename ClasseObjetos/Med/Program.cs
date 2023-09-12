using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Métodos Simples
            //m.Cumprimentar();
            #endregion

            #region Métodos com Parâmetros
            //m.Somar(2, 3);
            //m.Apresentar("Gustavo", 18);
            #endregion

            #region Passagem de Valores
            //int valor1 = 100, valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);

            //Console.WriteLine(valor1);
            //Console.WriteLine(valor2);
            #endregion

            #region Retorno de Valores
            Console.WriteLine(m.CodigoChar('A'));
            Console.WriteLine(m.MontaNome("Gustavo","Henrique"));
            Console.WriteLine(m.ValorPi());
            #endregion

            #region Métodos com Sobrecarga

            m.Cumprimentar();
            m.Cumprimentar("Gustavo");
            m.Cumprimentar("Henrique", 10);

            Console.WriteLine(m.Comparar(1 * 2, 2));
            Console.WriteLine(m.Comparar("Gustavo", "Henrique"));

            #endregion


        }
    }
}
