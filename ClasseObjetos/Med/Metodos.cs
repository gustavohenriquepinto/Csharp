using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med
{
    class Metodos
    {
        # region Métodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, mundo!");
        }
        #endregion

        #region Métodos com parâmetros
        public void Somar(int n1, int n2)
        {
            int soma = n1 + n2;
            Console.WriteLine("A soma é " + soma);
        }

        public void Apresentar(string nome, byte idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
        }
        #endregion

        #region Passagem por valor
        // Passagem de métodos por valor, ou seja, o valor utilizado como parâmetro permanece o mesmo após a execução do método
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("O valor é " + valor);
        }

        // Passagem de métodos por referência, ou seja, é capaz de mudar o valor do parâmetro após a execução do método
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("O valor da referência é " + valor);
        }
        #endregion

        #region Retorno de Valores
        //Métodos com retornos de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + "" + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = (int)caractere;
            return caractere;
        }

        public double ValorPi()
        {
            return 3.1415;
        }
        #endregion

        #region Métodos com Sobrecarga

        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá, " + nome);
        }
        public void Cumprimentar(string nome, int hora)
        {

            string mensagem = hora < 12 ? "Bom dia, " + nome : "Boa tarde, " + nome;

            Console.WriteLine(mensagem);
        }
        public bool Comparar(int n1,int n2)
        {
            return n1 == n2;
        }
        public bool Comparar(string txt1, string txt2)
        {
            return txt1 == txt2;
        }

        #endregion
    }
}
