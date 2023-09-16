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

            c._cliente = "Gustavo";
            c._saldo = 100;

            //Depósito
            Console.Write("Deposite: ");
            double deposito = double.Parse(Console.ReadLine());
            c.Depositar(deposito);

            //Saque
            Console.Write("\nSaque: ");
            double saque = double.Parse(Console.ReadLine());
            c.Depositar(saque);

            Console.WriteLine("\nO valor final é de: " + c._saldo);
            Console.ReadKey();
        }
    }
}
