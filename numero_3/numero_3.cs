using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Os primeiros 11 números da sequência de Fibonacci:");
        
        // Chama a função para gerar os 11 primeiros números
        long[] fibonacci = GerarFibonacci(11);
        
        // Loop para exibir cada número com sua posição
        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.WriteLine($"{i + 1}º: {fibonacci[i]}");
        }
    }
    
    // Função que gera os primeiros n números da sequência de Fibonacci
    static long[] GerarFibonacci(int n)
    {
        // Se n for menor ou igual a 0, retorna array vazio
        if (n <= 0)
            return new long[0];
        
        // Cria array para armazenar a sequência
        long[] sequencia = new long[n];
        
        // Primeiro número da sequência é 0
        sequencia[0] = 0;
        
        // Se n for 1, retorna apenas o 0
        if (n == 1)
            return sequencia;
        
        // Segundo número da sequência é 1
        sequencia[1] = 1;
        
        // Gera os números restantes (cada número é a soma dos dois anteriores)
        for (int i = 2; i < n; i++)
        {
            sequencia[i] = sequencia[i - 1] + sequencia[i - 2];
        }
        
        // Retorna o array com a sequência completa
        return sequencia;
    }
}