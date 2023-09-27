using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Recursivo
    {
        public void Executar(string mensagem, int numero)
        {
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(mensagem);
            }
        }

        public void ExecutarRecursivo(string mensagem, int numero)
        {
            if (numero > 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, numero - 1);
            }
        }
    }
}
