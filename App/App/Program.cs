using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args) {
            /*1.1 Faça um programa para verificar se o número é par ou 
                ímpar. O programa deve receber um número e imprimir o 
                resultado Par ou Impar.
                Numero par, são os números divisíveis 
                por 2 que tem o resto 0.
            */
            void Questao1_1(int numero) {
                int resultado = numero % 2;

                //Se a condição for verdadeira
                if (resultado == 0) {
                    Console.WriteLine("É par");
                } else { // Senão, faz aqui
                    Console.WriteLine("É ímpar");
                }
            }
            Questao1_1(7);
        }
    }
}
