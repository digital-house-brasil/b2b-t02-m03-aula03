using System;
internal class Program
{
    private static void Main(string[] args)
    {
    //Faça um programa para verificar se o número é positivo ou negativo.
    // O programa deve receber um número e imprimir o resultado ou . PositivoNegativo
    //Número positivo, são os números que são maiores que 0. Número positivo, são os números que são maiores que 0.
        const int  i = 1;
        int n = 0;
        while(i>0){
        Console.Write("digite um numero: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n >0){
            Console.WriteLine("Positivo");
        }
        else if (n == 0){
            Console.WriteLine("voce digitou zero digite outro numero");
        }
        else{
            Console.WriteLine("Negativo");
        }
        
        }
    }   
}