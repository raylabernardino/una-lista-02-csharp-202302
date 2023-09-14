using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite um número:");
		string num = Console.ReadLine();
        Console.WriteLine("Digite uma base logarítmica para o número anterior:");
		string baseLog = Console.ReadLine();
		
        double numD = double.Parse(num);
        double baseLogD = double.Parse(baseLog);
			
		double resultado = Math.Log(numD, baseLogD);
		
		Console.WriteLine("O resultado do seu logaritmo será " + resultado + ".");
	}
}