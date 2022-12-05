using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + " " + sobrenome); 
        }
    }
}
