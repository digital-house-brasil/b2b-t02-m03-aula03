
using System;
internal class Program
{
    private static void Main(string[] args){
    
    //Faça um programa que receba a idade e verifique se a pessoa é maior de idade ou não. 
    //Deve exibir o resultado Maior de idade ou Menor de idade
    //Se a idade for maior ou igual a 18, é considerado maior de idade
    const int a = 1;
    int idade = 0;
    while(a > 0){
    Console.Write("digite sua idade ");
    idade =Convert.ToInt32(Console.ReadLine()); 
    if (idade >= 18){
        Console.WriteLine("Maior de Idade \n");
    }else{
        Console.WriteLine("Menor de Idade \n");
    }

    }

    }
    
    
    


    







       
}
