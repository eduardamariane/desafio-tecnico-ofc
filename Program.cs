using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("DESAFIO TÉCNICO\n");

            Console.WriteLine("Escolha o exercício para executar:");
            Console.WriteLine("1 - Cálculo de Comissão");
            Console.WriteLine("2 - Movimentação de Estoque");
            Console.WriteLine("3 - Cálculo de Juros");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite a opção desejada: ");

            string? opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Exercicio1_Comissao.Executar();
                    break;

                case "2":
                    Exercicio2_Estoque.Executar();
                    break;

                case "3":
                    Exercicio3_Juros.Executar();
                    break;

                case "0":
                    Console.WriteLine("FIM");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Clique em ENTER para voltar ao menu...");
            Console.ReadLine();
        }
    }
}