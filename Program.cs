
﻿using System;


class Program
{
    
    static double calcRazao(double etanol, double gasolina)
    {
        return etanol / gasolina;
    }

    static bool verifyRecomendacao(double razao)
    {
        double percentualLimite = 0.73;
        return razao <= percentualLimite;
    }

    static void Main()
    {
        Console.Clear();

        Console.Write("Digite o preço do etanol (em R$):");
        double precoEtanol = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o preço da gasolina (em R$):");
        double precoGasolina = Convert.ToDouble(Console.ReadLine());

        double razao = calcRazao(precoEtanol, precoGasolina);
        double razaoPorcentagem = razao * 100;
        
        Console.WriteLine("");
        Console.WriteLine($"Razão entre os preços: {razaoPorcentagem}%");

        bool recomendacao = verifyRecomendacao(razao);
        
        if (recomendacao)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Recomenda-se abastecer com gasolina.");
        }
        
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Recomenda-se abastecer com etanol.");
        }
        Console.WriteLine("");
        Console.ResetColor();
    }
}