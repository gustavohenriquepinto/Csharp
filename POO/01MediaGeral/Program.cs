using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01MediaGeral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Média Geral dos Alunos";

            Console.Write("Quantos alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno # " + (i + 1) + ": ");
                string nome = Console.ReadLine();

                Console.Write("Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno " + nome + ": ");
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.Media + "\n");

                mediaGeral += aluno.Media;
            }

            double resultadoGeral = mediaGeral / alunos.Length;

            Console.WriteLine("Média dos alunos: " + resultadoGeral);


            Console.ReadKey();
        }
    }
}
