using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string expressao = "x = a + b * d - c";
        GerarTresEnderecos(expressao);
    }

    static void GerarTresEnderecos(string expressao)
    {
        // Remove espaços da expressão
        expressao = expressao.Replace(" ", "");
        
        // Separa o lado esquerdo (variável destino) e direito (expressão)
        string[] partes = expressao.Split('=');
        string destino = partes[0];
        string expr = partes[1];
        
        List<string> codigo = new List<string>();
        int tempCount = 1;
        
        // Processa a expressão passo a passo
        // Primeiro: encontra e resolve multiplicações
        if (expr.Contains('*'))
        {
            // Encontra a posição do *
            int posMult = expr.IndexOf('*');
            
            // Encontra os operandos
            char operandoEsq = expr[posMult - 1];
            char operandoDir = expr[posMult + 1];
            
            // Gera temporário para a multiplicação
            string temp = "t" + tempCount;
            codigo.Add($"{temp} = {operandoEsq} * {operandoDir}");
            tempCount++;
            
            // Substitui a multiplicação pelo temporário na expressão
            expr = expr.Replace($"{operandoEsq}*{operandoDir}", temp);
        }
        
        // Agora processa soma e subtração da esquerda para direita
        for (int i = 0; i < expr.Length; i++)
        {
            if (expr[i] == '+' || expr[i] == '-')
            {
                char operador = expr[i];
                char operandoEsq = expr[i - 1];
                char operandoDir = expr[i + 1];
                
                string temp = "t" + tempCount;
                codigo.Add($"{temp} = {operandoEsq} {operador} {operandoDir}");
                tempCount++;
                
                // Substitui na expressão
                string subExpr = $"{operandoEsq}{operador}{operandoDir}";
                expr = expr.Replace(subExpr, temp);
                i = 0; // Reinicia para processar próximo operador
            }
        }
        
        // Último passo: atribui ao destino
        codigo.Add($"{destino} = {expr}");
        
        // Exibe o código gerado
        Console.WriteLine("Código de três endereços gerado:");
        foreach (string linha in codigo)
        {
            Console.WriteLine(linha);
        }
    }
}