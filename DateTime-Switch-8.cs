using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma letra: ");
        char letra = char.Parse(Console.ReadLine().ToLower());

        if (char.IsLetter(letra))
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("A letra '" + letra + "' é uma vogal.");
            }
            else
            {
                Console.WriteLine("A letra '" + letra + "' é uma consoante.");
            }
        }
        else
        {
            Console.WriteLine("O caractere digitado não é uma letra.");
        }
    }
}
