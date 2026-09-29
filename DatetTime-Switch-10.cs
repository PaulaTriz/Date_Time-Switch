using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escolha o tamanho da camiseta (P, M ou G): ");
        char tamanho = char.Parse(Console.ReadLine().ToUpper());

        switch (tamanho)
        {
            case 'P':
                Console.WriteLine("Tamanho P: R$ 25,00");
                break;
            case 'M':
                Console.WriteLine("Tamanho M: R$ 30,00");
                break;
            case 'G':
                Console.WriteLine("Tamanho G: R$ 35,00");
                break;
            default:
                Console.WriteLine("Tamanho inválido! Escolha P, M ou G.");
                break;
        }
    }
}
