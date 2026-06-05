namespace Bonus;

class Program
{

    static double CalcularMedia(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }
    static void Main(string[] args)
    {
        double n1, n2, n3;
        Console.WriteLine("Digite os valores para calcular a média: ");
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        double media = CalcularMedia(n1, n2, n3);
        Console.WriteLine($"A média é: {media}");
    }
}