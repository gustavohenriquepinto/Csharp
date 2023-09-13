using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    internal class Pessoa
    {
        public string nome, sobrenome;
        public int anoDeNascimento, idade;

        public Pessoa()
        {
            nome = "Sem nome";
            sobrenome = "Sem sobrenome";
            anoDeNascimento = 0;
            idade = 0;
        }
        public Pessoa(string nome, string sobrenome, int anoDeNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoDeNascimento = anoDeNascimento;
            this.idade = Idade();
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anoDeNascimento = 2000;
            this.idade = Idade();
        }


        private int Idade()
        {
            return 2023 - anoDeNascimento;
        }
    }
}
