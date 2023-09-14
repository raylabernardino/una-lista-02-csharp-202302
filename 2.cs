using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o valor do produto:");
		string valor = Console.ReadLine();
		
		double valorDouble = double.Parse(valor);
			
		double novoValor = valorDouble + (valorDouble * 0.1);
		
		Console.WriteLine("Novo valor do produto:");
		Console.WriteLine("R$" + novoValor);
	}
}