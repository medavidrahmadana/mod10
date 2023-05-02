// See https://aka.ms/new-console-template for more information
using AljabarLibraries;

internal class Program
{
    private static void Main(string[] args)
    {
        double[] persamaan1 = new double[] { 1, -3, -10 };
        double[] test = Aljabar.AkarPersamaanKuadrat(persamaan1);
        Console.WriteLine("Berikut hasil akar persamaan kuadrat: ");
        Console.Write("A. {" + test[0]);
        Console.WriteLine("," + test[1]+"}");
        double[] persamaan2 = { 2, -3 };
        double[] test2 = Aljabar.hasilKuadrat(persamaan2);
        Console.Write("B. {" + test2[0]);
        Console.Write("," + test2[1]);
        Console.Write(" " + test2[2] + "}");
        Console.WriteLine(" ");
    }
}