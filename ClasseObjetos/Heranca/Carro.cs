﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro : Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("O motor ligou!");
        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro");
        }
    }
}
