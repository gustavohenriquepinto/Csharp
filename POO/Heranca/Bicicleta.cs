using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed class Bicicleta : Veiculo
    {
        public void Pedalar()
        {
            Console.WriteLine("Está pedalando!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bicicleta");
        }
    }
}
