using System;
internal class Programa
{
    private static void Main(string[] args)
    {
    /*1.1 Faça um programa para verificar se o número é par ou ímpar. O programa deve receber 
    um número e imprimir o resultado `Par` ou `Impar`.
    Numero par, são os números divisíveis por 2 que tem o resto 0.
    */
    int n = 0;
    
    while(n >= 0){
    Console.Write("digite um numero: ");
    n = Convert.ToInt32(Console.ReadLine());
    if ((n % 2) == 0){
        Console.WriteLine("Par \n");
    } else{
         Console.WriteLine("Impar \n");
    }
    }
    

    
    
    
    


    }
}