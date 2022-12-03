using System;
internal partial class Program
{
    private static void Main(string[] args)
    {
    //Faça um programa para verificar se o número é primo. O programa deve receber um número
    // e imprimir o resultado Primo ou Não primo.
    //Número primo, são os números que são divisíveis por 1 e por ele mesmo.
    const int a = 1;
    int n=0, cont = 0;
    while(a >0) {
    Console.Write("digite um numero: ");
    n = Convert.ToInt32(Console.ReadLine());
    for (int i=1; i<=n; i++){
        
        if(n%i == 0){
            cont++;
        }
        
    }
    if(cont == 2){
       Console.Write("Primo"); 
    }else{
        Console.Write("Não Primo");
    }
    cont = 0;
    
    Console.ReadKey();
    }


        
    }
}