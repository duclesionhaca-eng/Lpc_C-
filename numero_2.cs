using System;
using System.Collections.Generic;

class ClassificadorLexemas
{
    static void Main()
    {
        // Lista de palavras reservadas do C#
        HashSet<string> reservadas = new HashSet<string>
        {
            "int", "string", "if", "else", "for", "while", "class", "static", "void"
        };
        
        // Código para analisar
        string codigo = "int idade = 25; if (idade > 18) { Console.WriteLine(\"Ok\"); }";
        
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("\nClassificação:\n");
        
        // Separar por espaços e símbolos
        string[] tokens = codigo.Split(' ', '(', ')', '{', '}', ';', '=', '>', '<');
        
        foreach (string token in tokens)
        {
            if (string.IsNullOrWhiteSpace(token))
                continue;
            
            if (reservadas.Contains(token))
            {
                Console.WriteLine(token + " → Palavra Reservada");
            }
            else if (char.IsLetter(token[0]))
            {
                Console.WriteLine(token + " → Identificador");
            }
            else if (char.IsDigit(token[0]))
            {
                Console.WriteLine(token + " → Número");
            }
        }
    }
}
