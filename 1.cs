using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o primeiro valor:");
		string x = Console.ReadLine();
		Console.WriteLine("Digite o segundo valor:");
		string y = Console.ReadLine();
		
		double a = double.Parse(x);
		double b = double.Parse(y);
			
		double media = (a + b) / 2;
		
		Console.WriteLine("Média Aritmética: " + media);
	}
}