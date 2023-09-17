using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.Write("Qual é o seu nome?: ");
            c.Cliente = Console.ReadLine();
            Console.WriteLine("Olá, " + c.Cliente + ", seu saldo inicial é de: " + c.Saldo);

            //Depósito
            Console.Write("\nDeposite: ");
            double deposito = double.Parse(Console.ReadLine());
            c.Depositar(deposito);

            //Saque
            Console.Write("Saque (taxa de R$10,00): ");
            double saque = double.Parse(Console.ReadLine());
            c.Sacar(saque);

            Console.WriteLine("\n"+c.Cliente+", o seu saldo final é de: " + c.Saldo);
            Console.ReadKey();
        }
    }
}
