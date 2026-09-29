using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- MENU ---");
        Console.WriteLine("1 - Opção 1");
        Console.WriteLine("2 - Opção 2");
        Console.WriteLine("3 - Opção 3");
        Console.Write("Escolha uma opção (1, 2 ou 3): ");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.WriteLine("Você escolheu a Opção 1.");
        }
        else if (opcao == 2)
        {
            Console.WriteLine("Você escolheu a Opção 2.");
        }
        else if (opcao == 3)
        {
            Console.WriteLine("Você escolheu a Opção 3.");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
}
