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

            int n1, n2, n3, r1, r2, r3;
            n1 = 100;
            n2 = 10;
            n3 = 5;

            r1 = n1 + n2 * n3;
            r2 = n1 - n2 / n3;
            r3 = (n1 + n2) / n3;
            double r4 = (double)n1 / 3 + n2 * n1;

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);

            #endregion
        }
    }
}
