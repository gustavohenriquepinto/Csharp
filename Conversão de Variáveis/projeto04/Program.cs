using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversão Implícita
            //byte num1 = 100;
            //ushort num2 = num1;

            //float num3 = -4.8f;
            //double num4 = num3;

            //char let1 = 'C';
            //int let2 = let1;

            //Console.WriteLine(num2);
            //Console.WriteLine(num4);
            //Console.WriteLine(let2);

            #endregion

            #region Conversão Explícita

            //ushort num1 = 257;
            //byte num2 = (byte)num1;

            //float num3 = 125687.8546f;
            //int num4 = (int)num3;

            //char l1 = (char)97;

            #endregion

            #region Método Parse
            //string txt = "1985";
            //int n1 = int.Parse(txt);
            //double n2 = double.Parse("12,54");
            #endregion

            #region Classe Convert
            //string txt = Convert.ToString(2500);
            //bool logico = Convert.ToBoolean("true");
            #endregion        
        }
    }
}
