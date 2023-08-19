using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Numéricos Inteiros

            #region Integral Assinado
            ////Suporta número negativo
            //sbyte num1 = 10;
            //short num2 = 20;
            //int num3 = 30;
            //long num4 = 40L;
            #endregion

            #region Integral sem sinal
            ////Não suporta números negativos
            //byte num5 = 10;
            //ushort num6 = 20;
            //uint num7 = 30;
            //ulong num8 = 40L;
            #endregion

            //Console.WriteLine(num1);

            //num1 = 102;

            //Console.WriteLine(num1);

            //Console.ReadKey();


            //Byte = 8bits
            //Short = 16bits
            //int= 32bits
            //long= 64bits

            #endregion

            #region Numéricos Reais

            //float real1 = 143.95f; //32bits
            //double real2 = 25.4; //64bits
            //decimal real3 = 34685784455633.14m; //128bits

            #endregion

            #region Caractere

            char letra1 = 'C';
            char letra2 = '\n';
            char letra3 = '\0';
            char letra4 = '\\';

            #endregion

            Console.WriteLine(letra1);
            Console.WriteLine(letra2);
            Console.WriteLine(letra1);
            Console.WriteLine(letra3);
            Console.WriteLine(letra1);

        }
    }
}
