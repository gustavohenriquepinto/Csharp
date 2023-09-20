using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Bicicleta b = new Bicicleta();
            Caminhonete a = new Caminhonete();

            c.Acelerar();
            b.Acelerar();

            a.LigarMotor();


            Console.ReadKey();
        }
    }
}
