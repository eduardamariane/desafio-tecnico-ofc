using System;
using System.Collections.Generic;
using System.Linq;

public static class Exercicio2_Estoque
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Descricao { get; set; }
        public int Estoque { get; set; }
    }

    public class Movimento
    {
        public int Id { get; set; }
        public int CodigoProduto { get; set; }
        public string? Tipo { get; set; }
        public int Quantidade { get; set; }
        public int EstoqueFinal { get; set; }
    }

    public static void Executar()
    {
        Console.WriteLine("Exercício 2: Movimentação de Estoque\n");

        List<Produto> produtos = new List<Produto>
        {
            new Produto { Codigo=1, Descricao="Caneta Azul", Estoque=150 },
            new Produto { Codigo=2, Descricao="Caderno Universitário", Estoque=75 },
            new Produto { Codigo=3, Descricao="Borracha Branca", Estoque=200 },
            new Produto { Codigo=4, Descricao="Lápis Preto HB", Estoque=320 },
            new Produto { Codigo=5, Descricao="Marcador de Texto Amarelo", Estoque=90 }
        };

        List<Movimento> movimentos = new();
        int ultimoId = 1;

        int Movimentar(int codigo, string tipo, int quantidade)
        {
            var p = produtos.FirstOrDefault(x => x.Codigo == codigo);
            if (p == null) return -1;

            if (tipo == "entrada") p.Estoque += quantidade;
            else if (tipo == "saida") p.Estoque -= quantidade;

            movimentos.Add(new Movimento
            {
                Id = ultimoId++,
                CodigoProduto = codigo,
                Tipo = tipo,
                Quantidade = quantidade,
                EstoqueFinal = p.Estoque
            });

            return p.Estoque;
        }

        Console.WriteLine($"Caneta Azul -> Estoque final: {Movimentar(1, "entrada", 20)}");
        Console.WriteLine($"Caderno Universitário -> Estoque final: {Movimentar(2, "saida", 10)}");
        Console.WriteLine($"Marcador Amarelo -> Estoque final: {Movimentar(5, "saida", 5)}");

        Console.WriteLine("\nMovimentações:");
        foreach (var m in movimentos)
        {
            Console.WriteLine($"ID {m.Id} - Produto {m.CodigoProduto} - {m.Tipo} | Qtd {m.Quantidade} -> Estoque agora: {m.EstoqueFinal}");
        }

        Console.WriteLine("\n===========================\n");
    }
}