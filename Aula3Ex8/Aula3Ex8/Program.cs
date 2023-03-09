using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            Console.WriteLine("Digite o número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o número 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
                resultado = num1 - num2;
            else
                resultado = num2 - num1;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
