using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado 1: ");
            float lado1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor do lado 2: ");
            float lado2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado 3: ");
            float lado3 = float.Parse(Console.ReadLine());
        
            if (lado1==lado2 && lado2 == lado3)
            {
                Console.WriteLine("O Triângulo é equilátero");
            }
            else if (lado1 == lado2 && lado2 != lado3 || lado2 == lado3 && lado1 != lado2 || lado1 == lado3 && lado1 !=2)
            {
                Console.WriteLine("O Triângulo é Isósceles");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno");
            }
        }
    }
}
