using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a primeira data (dia/mes/data): ");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

        Console.Write("Digite a segunda data (dia/mes/data): ");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

        TimeSpan diferenca = data2 - data1;
        int dias = Math.Abs(diferenca.Days);

        Console.WriteLine("A diferença entre as datas é de " + dias + " dias.");
    }
}