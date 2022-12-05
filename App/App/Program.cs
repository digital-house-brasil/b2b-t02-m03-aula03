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
            void Questao1_1() {
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                int resultado = numero % 2;
                //Se a condição for verdadeira
                if (resultado == 0) {
                    Console.WriteLine("É par");
                } else { // Senão, faz aqui
                    Console.WriteLine("É ímpar");
                }
                Console.ReadKey();
            }
            //Questao1_1();

            /*1.2 Faça um programa para verificar se o número é positivo ou negativo. 
             * O programa deve receber um número e imprimir o resultado Positivo ou Negativo.
             * Número positivo, são os números que são maiores que 0. Número positivo, 
             * são os números que são maiores que 0.
            */
            void Questao1_2() {
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                
                if (numero >= 0) {
                    Console.WriteLine("Positivo");
                } else {
                    Console.WriteLine("Negativo");
                }
                Console.ReadKey();
            }
            //Questao1_2();

            //1.3 Faça um programa para verificar se o número é primo. O programa deve receber um número e
            //imprimir o resultado Primo ou Não primo.
            //Número primo, são os números que são divisíveis por 1 e por ele mesmo.
            void Questao1_3() {
                
            }


            //1.4 Faça um programa programa para verificar se um triângulo é equilátero,
            //isósceles ou escaleno.O programa deve ler os valores dos três lados e escrever o nome do
            //tipo de triângulo correspondente.
            //Triângulo equilátero, são os triângulos que possuem todos os lados iguais.
            //Triângulo isósceles, são os triângulos que possuem dois lados iguais.
            //Triângulo escaleno, são os triângulos que possuem todos os lados diferentes.

            void Questao1_4() {
                Console.WriteLine("Digite o 1º lado do triângulo: ");
                int lado1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2º lado do triângulo: ");
                int lado2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 3º lado do triângulo: ");
                int lado3 = int.Parse(Console.ReadLine());

                if ((lado1 == lado2) && (lado2 == lado3)) {
                    Console.WriteLine("Triângulo equilátero");
                }
                if (
                    ((lado1 == lado2) && (lado2 != lado3)) || 
                    ((lado1 == lado3) && (lado2 != lado1)) ||
                    ((lado2 == lado3) && (lado3 != lado1))) {
                    Console.WriteLine("Triângulo isósceles");
                } 
                if ((lado1 != lado2) && (lado2 != lado3)) {
                    Console.WriteLine("Triângulo escaleno");
                }
                Console.ReadKey();
            }
            //Questao1_4();

            //1.5 Faça um programa que receba o nome e depois o sobrenome, no final deve exibir o resultado
            //nome + sobrenome. Utilize o operador + para concatenar 2 variáveis do tipo string
            void Questao1_5() {
                Console.WriteLine("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu sobrenome: ");
                string sobrenome = Console.ReadLine();

                Console.WriteLine("Seu nome completo é: " + (nome + sobrenome));
                
                Console.ReadKey();
            }

            //Questao1_5();

            //1.6 Faça um programa que receba a idade e verifique se a pessoa é maior de idade ou não.
            //Deve exibir o resultado Maior de idade ou Menor de idade
            //Se a idade for maior ou igual a 18, é considerado maior de idade
            void Questao1_6() {
                Console.WriteLine("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18) {
                    Console.WriteLine("Maior de idade");
                } else {
                    Console.WriteLine("Menor de idade");
                }
                Console.ReadKey();
            }

            Questao1_6();
        }
    }
}
