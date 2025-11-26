using System;
using System.Collections.Generic;

public static class Exercicio1_Comissao
{
    public class Venda
    {
        public string? Vendedor { get; set; }
        public double Valor { get; set; }
    }

    public static void Executar()
    {
        Console.WriteLine("Exercício 1: Comissão\n");

        List<Venda> vendas = new List<Venda>
        {
            new Venda { Vendedor="João Silva", Valor=1200.50 },
            new Venda { Vendedor="João Silva", Valor=950.75 },
            new Venda { Vendedor="João Silva", Valor=1800.00 },
            new Venda { Vendedor="João Silva", Valor=1400.30 },
            new Venda { Vendedor="João Silva", Valor=1100.90 },
            new Venda { Vendedor="João Silva", Valor=1550.00 },
            new Venda { Vendedor="João Silva", Valor=1700.80 },
            new Venda { Vendedor="João Silva", Valor=250.30 },
            new Venda { Vendedor="João Silva", Valor=480.75 },
            new Venda { Vendedor="João Silva", Valor=320.40 },

            new Venda { Vendedor="Maria Souza", Valor=2100.40 },
            new Venda { Vendedor="Maria Souza", Valor=1350.60 },
            new Venda { Vendedor="Maria Souza", Valor=950.20 },
            new Venda { Vendedor="Maria Souza", Valor=1600.75 },
            new Venda { Vendedor="Maria Souza", Valor=1750.00 },
            new Venda { Vendedor="Maria Souza", Valor=1450.90 },
            new Venda { Vendedor="Maria Souza", Valor=400.50 },
            new Venda { Vendedor="Maria Souza", Valor=180.20 },
            new Venda { Vendedor="Maria Souza", Valor=90.75 },

            new Venda { Vendedor="Carlos Oliveira", Valor=800.50 },
            new Venda { Vendedor="Carlos Oliveira", Valor=1200.00 },
            new Venda { Vendedor="Carlos Oliveira", Valor=1950.30 },
            new Venda { Vendedor="Carlos Oliveira", Valor=1750.80 },
            new Venda { Vendedor="Carlos Oliveira", Valor=1300.60 },
            new Venda { Vendedor="Carlos Oliveira", Valor=300.40 },
            new Venda { Vendedor="Carlos Oliveira", Valor=500.00 },
            new Venda { Vendedor="Carlos Oliveira", Valor=125.75 },

            new Venda { Vendedor="Ana Lima", Valor=1000.00 },
            new Venda { Vendedor="Ana Lima", Valor=1100.50 },
            new Venda { Vendedor="Ana Lima", Valor=1250.75 },
            new Venda { Vendedor="Ana Lima", Valor=1400.20 },
            new Venda { Vendedor="Ana Lima", Valor=1550.90 },
            new Venda { Vendedor="Ana Lima", Valor=1650.00 },
            new Venda { Vendedor="Ana Lima", Valor=75.30 },
            new Venda { Vendedor="Ana Lima", Valor=420.90 },
            new Venda { Vendedor="Ana Lima", Valor=315.40 }
        };

        Dictionary<string, double> comissoes = new();

        foreach (var venda in vendas)
        {
            double percentual =
                venda.Valor < 100 ? 0 :
                venda.Valor < 500 ? 0.01 : 0.05;

            double valorComissao = venda.Valor * percentual;

            if (venda.Vendedor != null)
            {
                if (!comissoes.ContainsKey(venda.Vendedor))
                    comissoes[venda.Vendedor] = 0;

                comissoes[venda.Vendedor] += valorComissao;
            }
        }

        foreach (var item in comissoes)
            Console.WriteLine($"{item.Key}: R${item.Value:F2}");

        Console.WriteLine("\n===========================\n");
    }
}