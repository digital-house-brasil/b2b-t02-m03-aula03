using System;

internal class Program
{
    private static void Main(string[] args)
    {
    //Faça um programa programa para verificar se um triângulo é equilátero, isósceles ou
    // escaleno. O programa deve ler os valores dos três lados e escrever o nome do tipo de
    // triângulo correspondente.
    //Triângulo equilátero, são os triângulos que possuem todos os lados iguais.
    // Triângulo isósceles, são os triângulos que possuem dois lados iguais.
    // Triângulo escaleno, são os triângulos que possuem todos os lados diferentes.
    int lado1 = 0, lado2 = 0, lado3 = 0;
    const int a = 1;
    while(a > 0){
    Console.Write("digital o valor do lado1 :");
    lado1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("digital o valor do lado2 :");
    lado2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("digital o valor do lado3 :");
    lado3 = Convert.ToInt32(Console.ReadLine());
    if (lado1 == lado2 && lado2 == lado3){
       Console.Write("Triângulo equilátero \n"); 
    }
    else if (lado1 == lado2 && lado1 !=lado3 || lado1 == lado3 && lado1 !=lado2){
        Console.Write("Triângulo isósceles \n"); 
    }
    else{
        Console.Write("Triângulo escaleno \n");
    }
    }





        
    }
}