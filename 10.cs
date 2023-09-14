using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o valor do primeiro número:");
		double num1 = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite o valor do segundo número:");
		double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do terceiro número:");
		double num3 = double.Parse(Console.ReadLine());

        double multi = num1 * num2 * num3;
        double mediaAritmetica = (num1 + num2 + num3) / 3;
        double mediaHarmonica = 3 / (1 / num1 + 1 / num2 + 1 / num3);
        double mediaGeometrica = Math.Pow(multi, 1.0/3.0);

        Console.WriteLine("Média Aritmética: " + mediaAritmetica);
        Console.WriteLine("Média Harmônica: " + mediaHarmonica);
        Console.WriteLine("Média Geométrica: " + mediaGeometrica);
	}
}
