using System;

public static class Exercicio3_Juros
{
    public static void Executar()
    {
        Console.WriteLine("Exercício 3: Juros\n");

        double valor = 1000;
        string dataVencimento = "01/02/2025";

        DateTime venc = DateTime.Parse(dataVencimento);
        int diasAtraso = (DateTime.Now - venc).Days;

        if (diasAtraso < 0) diasAtraso = 0;

        double juros = valor * 0.025 * diasAtraso;

        Console.WriteLine($"Valor: R${valor}");
        Console.WriteLine($"Vencimento: {dataVencimento}");
        Console.WriteLine($"Dias em atraso: {diasAtraso}");
        Console.WriteLine($"Juros calculado: R${juros:F2}");

        Console.WriteLine("\n===========================\n");
    }
}