using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Switch - case
        //Console.WriteLine("Escolha um valor de 1 a 4");
        //int num = int.Parse(Console.ReadLine());

        //switch (num)
        //{
        //    case 1:
        //        Console.WriteLine("Você escolheu 1");
        //        break;
        //    case 2:
        //        Console.WriteLine("Você escolheu 2");
        //        break;
        //    case 3:
        //    case 4:
        //        Console.WriteLine("Você escolheu 3 ou 4");
        //        break;
        //    default:
        //        Console.WriteLine("Você não escolheu 1, 2, 3 ou 4");
        //        break;


        //}
        #endregion

        #region goto
        //Inicio:
        //Console.Write("Escolha 1 ou 2: ");
        //int op= int.Parse(Console.ReadLine());
        //int valor = 0;

        //switch (op)
        //{
        //    case 1:
        //        valor += 50;
        //        break;
        //    case 2:
        //        valor += 100;
        //        goto case 1;
        //    default:
        //        Console.WriteLine("Valor fora dos parâmetros\n");
        //        goto Inicio;
        //}

        //Console.WriteLine("\nValor final é de: "+valor);
        #endregion

        Inicio:
            Console.Clear();
            Console.WriteLine("==========\nCalculadora\n==========\n");

            Console.Write("Digite o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha uma opção entre +, -, *, /: ");
            char operacao = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                default:
                    Console.WriteLine("Operação inválida\n");
                    goto Continuar;
                case '+':
                    resultado = n1+n2;
                    break;
                case '-':
                    resultado = n1 - n2;
                    break;
                case '*':
                    resultado = n1 * n2;
                    break;
                case '/':

                    if (n2 == 0)
                    {
                        Console.WriteLine("Não é possível realizar a divisão por 0.\n");
                        goto Continuar;
                    }
                    else
                    {
                        resultado = n1 / n2;
                    }       

                    break;
            }

            Console.WriteLine("\nO resultado da operação é de : " + resultado+"\n");

        Continuar:
            Console.WriteLine("Continuar calculando? (Sim)");
            string continuar = Console.ReadLine();

            if (continuar == "sim" || continuar == "Sim")
            {
                goto Inicio;
            }

        }
    }
}
