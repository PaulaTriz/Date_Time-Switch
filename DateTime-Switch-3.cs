using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a sua data de nascimento (dd/mm/aaaa): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
        DateTime hoje = DateTime.Today;

        int idade = hoje.Year - dataNascimento.Year;

        if (dataNascimento.Date > hoje.AddYears(-idade))
        {
            idade--;
        }

        Console.WriteLine("A sua idade é: " + idade + " anos.");
    }
}
