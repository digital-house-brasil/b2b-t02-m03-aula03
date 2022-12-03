using System;

internal partial class Program
{
    private static void Main(string[] args)
    {
    //Faça um programa que receba o nome e depois o sobrenome, no final deve exibir
    // o resultado nome + sobrenome
    //Utilize o operador + para concatenar 2 variáveis do tipo string

    string nome = "", sobrenome = "";
    Console.Write("Olá poderia responder as perguntas? \n");
    Console.Write("digite o seu nome: ");
    nome = Console.ReadLine();
    Console.Write("digite o seu sobrenome: ");
    sobrenome = Console.ReadLine();
    Console.WriteLine("obrigado por responder "+nome + sobrenome);
    Console.ReadKey();





       
    }
}