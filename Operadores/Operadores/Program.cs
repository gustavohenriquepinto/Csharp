using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Aritméticos
            //byte n1 = 10 + 2;
            //sbyte n2 = 8 - 15;
            //byte n3 = Convert.ToByte(n1 + n2);
            //int n4 = n1 + n2;

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);

            //double n1 = 2;
            //double n2 = 3;

            //Console.WriteLine(n1 + n2);
            //Console.WriteLine(n1 - n2);
            //Console.WriteLine(n1 * n2);
            //Console.WriteLine(n1 / n2);
            //Console.WriteLine(n1 % n2);

            #endregion

            #region Precedência de Operadores

            //int n1, n2, n3, r1, r2, r3;
            //n1 = 100;
            //n2 = 10;
            //n3 = 5;

            //r1 = n1 + n2 * n3;
            //r2 = n1 - n2 / n3;
            //r3 = (n1 + n2) / n3;
            //double r4 = (double)n1 / 3 + n2 * n1;

            //Console.WriteLine(r1);
            //Console.WriteLine(r2);
            //Console.WriteLine(r3);
            //Console.WriteLine(r4);

            #endregion

            #region Operadores de Incremento e Decremento
            //int n1 = 10;
            //n1++;
            //Console.WriteLine(n1);
            //n1--;
            //Console.WriteLine(n1);
            //Console.WriteLine(n1++);
            //Console.WriteLine(--n1);
            #endregion

            #region Operador de Concatenação
            //string nome1 = "Gustavo ";
            //string nome2 = "Henrique";
            //string NomeCompleto = nome1 + nome2;

            //Console.WriteLine("Gustavo "+"Henrique");
            //Console.WriteLine(NomeCompleto);
            #endregion

            #region Operadores de Atribuição
            //double n1, n2;
            //n1 = 4;
            //n2 = 7;

            //n1 = n2;
            //Console.WriteLine(n1);

            //n1 = 4;
            //n1 += n2;
            //Console.WriteLine(n1);

            //n1 = 4;
            //n1 -= n2;
            //Console.WriteLine(n1);

            //n1 = 4;
            //n1 *= n2;
            //Console.WriteLine(n1);

            //n1 = 4;
            //n1 /= n2;
            //Console.WriteLine(n1);

            //n1 = 4;
            //n1 %= n2;
            //Console.WriteLine(n1);
            #endregion

            #region Operadores de Igualdade

            //bool Log;
            //Log = 10 != 10;
            //Log = 10 < 2;
            //Log = 10 > 4;
            //Log = 10 >= 5;
            //Log = 10 <= 10;

            //Console.WriteLine(Log);

            #endregion

            #region Operadores Lógicos

            bool Log1 = true && true;
            bool Log2 = true && false;
            bool Log3 = false && true;
            bool Log4 = false && false;

            bool Log5 = true || true;
            bool Log6 = true || false;
            bool Log7 = false || true;
            bool Log8 = false || false;

            Console.WriteLine(Log1);
            Console.WriteLine(Log2);
            Console.WriteLine(Log3);
            Console.WriteLine(Log4);
            Console.WriteLine(Log5);
            Console.WriteLine(Log6);
            Console.WriteLine(Log7);
            Console.WriteLine(Log8);

            #endregion
        }
    }
} 
