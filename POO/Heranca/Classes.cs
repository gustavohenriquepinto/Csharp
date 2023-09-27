using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }
        public void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
        public virtual void Nariz()
        {
            Console.WriteLine("Humano.Nariz");
        }
    }
    class Pessoa : Humano
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }
        //public override void Cabelos()
        //{
        //    Console.WriteLine("Pessoa.Cabelos");
        //}
        public override void Nariz()
        {
            Console.WriteLine("Pessoa.Nariz");
        }
    }
    class Homem : Pessoa
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}
        //public override void Cabelos()
        //{
        //    Console.WriteLine("Homem.Cabelos");
        //}
        public override void Nariz()
        {
            Console.WriteLine("Homem.Nariz");
        }

        public void Teste()
        {
            Cabelos();
            Console.ReadKey();
        }
        
        
    }
}
