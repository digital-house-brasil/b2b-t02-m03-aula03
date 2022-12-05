using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade>= 18)
            {
                Console.WriteLine("Maior de idade");
            }
            else
            {
                Console.WriteLine("Menor de idade");
            }
        }
    }
}
