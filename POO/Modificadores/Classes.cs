using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        public string nome;
        private string sobrenome;

        private void Metodo() { }
        public void Executar() { }

    }
    class Humano
    {
        protected string nome;
        private string sobrenome;
    }
    class Homem : Humano
    {
        public void Metodo() { 
            nome="";
        }
    }
}
