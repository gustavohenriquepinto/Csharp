using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Vetores
            //int[] numeros = new int[5];
            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //string[] nome = {"NomeA","NomeB","NomeC"};

            //Console.WriteLine(numeros[0]);
            //Console.WriteLine(numeros[1]);
            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(numeros[4]);

            //Console.WriteLine(nome[0]);
            //Console.WriteLine(nome[1]);
            //Console.WriteLine(nome[2]);
            #endregion

            #region Matrizes
            //int[,] num = new int[2,3];

            //num[0,0] = 0;
            //num[0,1] = 1;
            //num[0,2] = 2;

            //num[1,0] = 3;
            //num[1,1] = 4;
            //num[1,2] = 5;

            //Console.Write(num[0, 0]);
            //Console.Write(num[0, 1]);
            //Console.WriteLine(num[0, 2]);
            //Console.Write(num[1, 0]);
            //Console.Write(num[1, 1]);
            //Console.WriteLine(num[1, 2]);

            //string[,] nomes =
            //{
            //    {"NomeA", "NomeB", "NomeC" },
            //    {"NomeD", "NomeE", "NomeF" }
            //};

            //Console.WriteLine();

            //Console.Write(nomes[0, 0]);
            //Console.Write(nomes[0, 1]);
            //Console.WriteLine(nomes[0, 2]);
            //Console.Write(nomes[1, 0]);
            //Console.Write(nomes[1, 1]);
            //Console.WriteLine(nomes[1, 2]);
            #endregion

            int[,] matrizA = new int[2, 3];
            int[,] matrizB = new int[3, 2];
            int[,] matrizC = new int[2, 2];

            Console.WriteLine("Digite os valores da matriz A:");
            for (int linha = 0; linha < 2; linha++)
            {
                for(int coluna =0; coluna < 3; coluna++)
                {
                    Console.Write("A: [" + linha + "," + coluna + "]");
                    matrizA[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDigite os valores da matriz B:");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("B: [" + linha + "," + coluna + "]");
                    matrizB[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            matrizC[0, 0] = matrizA[0, 0] * matrizB[0, 0] + matrizA[0, 1] * matrizB[1, 0] + matrizA[0, 2] * matrizB[2, 0];
            matrizC[0, 1] = matrizA[0, 0] * matrizB[0, 1] + matrizA[0, 1] * matrizB[1, 1] + matrizA[0, 2] * matrizB[2, 1];
            matrizC[1, 0] = matrizA[1, 0] * matrizB[0, 0] + matrizA[1, 1] * matrizB[1, 0] + matrizA[1, 2] * matrizB[2, 0];
            matrizC[1, 1] = matrizA[1, 0] * matrizB[0, 1] + matrizA[1, 1] * matrizB[1, 1] + matrizA[1, 2] * matrizB[2, 1];

            Console.WriteLine("\nResulatdo do produto das matrizes:");
            Console.WriteLine("[" + matrizC[0, 0] + "][" + matrizC[0, 1] + "]");
            Console.WriteLine("[" + matrizC[1, 0] + "][" + matrizC[1, 1] + "]");



        }
    }
}
