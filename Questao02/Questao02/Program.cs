using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            float valor = float.Parse(Console.ReadLine());
            if (valor >= 0)
            {
                Console.WriteLine("O valor é positivo");
            }
            else
            {
                Console.WriteLine("O valor é negativo");
            }
        }
    }
}
