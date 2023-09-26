using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Forma
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Altura { get; private set; }
        public int Largura { get; private set; }
        public int Raio { get; private set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar.");
        }

        public virtual void Area() { }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um círculo.");
        }

        public override void Area()
        {
            double area = 3.14 * Math.Pow(Raio, 2);
            Console.WriteLine("Área do círculo: " + area);
        }
        
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um retângulo.");
        }

        public override void Area()
        {
            double area = Largura*Altura;
            Console.WriteLine("Área do retângulo: " + area);
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um triângulo.");
        }

        public override void Area()
        {
            double area = Largura * Altura / 2;
            Console.WriteLine("Área do triângulo: " + area);
        }
    }
}
