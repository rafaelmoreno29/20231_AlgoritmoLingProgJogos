using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            double qtdeEntrada, qtdeSaida;

            Console.WriteLine("Digite o Tipo [M ou F]");
            tipo = Console.ReadLine();
            Console.WriteLine("Digite a quantidade");
            qtdeEntrada = Convert.ToDouble(Console.ReadLine());

            if(tipo == "M")
            {
                qtdeSaida = 200 * qtdeEntrada / 500;
                Console.WriteLine("A qtde de frios é: " + qtdeSaida);
            }
            else
            {
                qtdeSaida = 500 * qtdeEntrada / 200;
                Console.WriteLine("A qtde de manteiga é: " + qtdeSaida);
            }
            Console.ReadKey();
        }
    }
}
