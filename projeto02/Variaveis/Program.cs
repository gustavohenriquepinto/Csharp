using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {

        //enum Notas
        //{
        //    Minima = 10,
        //    Media = 23,
        //    Maxima =  352
        //}

        struct Cadastro
        {
            public string nome;
            public byte idade;
            public float altura;
        }


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

            //char letra1 = 'C';
            //char letra2 = '\n';
            //char letra3 = '\0';
            //char letra4 = '\\';

            #endregion

            #region Valor Lógico

            bool VouF = true;
            bool VeF = false;

            #endregion

            #region Textos

            //string texto = "Olá, mundo!";
            //string simbolo = "!@#$%¨&*()^´]\n.,<>:?/°";

            #endregion

            #region Tipo Var

            //var numero = -124; //Pode assumir um valor numérico real
            //var text = "Lorem Ipsum"; //Pode assumir valor de string
            //var logico = false; //Pode assumir valor lógico

            #endregion

            #region Tipo Object

            //object obj = 100;
            //obj = true;
            //obj = "Curso em Vídeo";

            #endregion

            #region Constante

            //const float pi = 3.1415f;
            //const string nome = "Gustavo";

            #endregion

            #region Enumerações

            //Notas NotasdosAlunos = Notas.Media;

            #endregion

            #region Estrutura

            Cadastro p1 = new Cadastro();
            p1.nome = "Gustavo";
            p1.idade = 18;
            p1.altura = 1.72f;

            #endregion

            Console.WriteLine("Olá, meu nome é " + p1.nome + ", tenho " + p1.idade + " anos e " + p1.altura + "m de altura.\n");


        }
    }
}
