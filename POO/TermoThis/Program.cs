using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();

            Console.WriteLine("Digite a senha abaixo para acessar o conteúdo");
            string mensagem = a.Login(Console.ReadLine()) == true ? "Você acertou a senha! Parabéns!" : "Senha errada, tente novamente";
            Console.WriteLine(mensagem);
        }
    }
}
