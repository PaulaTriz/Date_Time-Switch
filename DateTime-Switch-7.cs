using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escolha uma cor (vermelho, azul ou verde): ");
        string cor = Console.ReadLine().ToLower().Trim();

        if (cor == "vermelho" || cor == "azul" || cor == "verde")
        {
            Console.WriteLine("A cor escolhida foi: " + cor);
        }
        else
        {
            Console.WriteLine("Cor inválida!");
        }
    }
}