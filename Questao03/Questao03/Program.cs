using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            float valor = float.Parse(Console.ReadLine());
            bool resposta = true;

            if (valor == 1)
            {
                resposta = true;
            }
            else
            {
                for (int i = 2; i < valor; i++)
                {
                    float div = valor % i;
                    if (div == 0)
                    {
                        resposta = false;
                    }
                }
            }
            if (resposta == true)
            {
                Console.WriteLine("O valor é primo");
            }
            else 
            {
                Console.WriteLine("O valor não é primo");
            }
        }
    }
}
