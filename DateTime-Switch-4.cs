using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma data (data/mes): ");
        string data = Console.ReadLine().Trim();

        // Exemplo com alguns feriados nacionais fixos no Brasil que eu peguei para esse codigo.
        if (data == "01/01" || data == "21/04" || data == "01/05" ||
            data == "07/09" || data == "12/10" || data == "02/11" ||
            data == "15/11" || data == "20/11" || data == "25/12")
        {
            Console.WriteLine("A data " + data + " é um feriado nacional!");
        }
        else
        {
            Console.WriteLine("A data " + data + " não é um feriado nacional fixo.");
        }
    }
}
