using System;

class Program
{
    static void Main()
    {
        // Saída
        Console.WriteLine("Olá Mundo!");
        
        // Variáveis
        int idade = 20;
        string nome = "Maria";
        
        // Entrada (corrigido com !)
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine()!;
        
        // Condição
        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        
        // Loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
        
        // Função
        Console.WriteLine(Somar(5, 3));
    }
    
    static int Somar(int a, int b)
    {
        return a + b;
    }
}
