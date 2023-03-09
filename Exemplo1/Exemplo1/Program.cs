using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, r;

            Console.WriteLine("Digite a base");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura");
            a = Convert.ToDouble(Console.ReadLine());

            r = b * a;

            //Math.Pow((a+b), 2);

            Console.WriteLine("A área é: " + r);

            Console.WriteLine("Digite uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
