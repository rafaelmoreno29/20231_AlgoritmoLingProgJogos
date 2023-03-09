using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distancia, litros, media;
            Console.WriteLine("Digite a distância");
            distancia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a qtde de litros");
            litros = Convert.ToDouble(Console.ReadLine());

            media = distancia / litros;

            Console.WriteLine("A média é: " + media);
            Console.ReadKey();
        }
    }
}
