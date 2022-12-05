using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            float valor = int.Parse(Console.ReadLine());
            if (valor % 2 == 0)
            {
                Console.WriteLine("O valor é Par");
            }
            else if(valor % 2 != 0){
                Console.WriteLine("O valor é Ímpar");
            }
            else
            {
                Console.WriteLine("O valor é inválido");
            }
        }   
    }
}
