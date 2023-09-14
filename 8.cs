using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite o total de veículos no estacionamento:");
		string veiculos = Console.ReadLine();
        Console.WriteLine("Digite o total de rodas no estacionamento:");
		string rodas = Console.ReadLine();
		
		double veiculosNum = double.Parse(veiculos);
        double rodasNum = double.Parse(rodas);

        double carros = (rodasNum - 2 * veiculosNum) / 2;
        double motos = veiculosNum - carros;

        if (carros >= 0 && motos >= 0 && carros % 1 == 0 && motos % 1 == 0) {
            Console.WriteLine($"No estacionamento, há {carros} carros e {motos} motos.");
        }
        else {
            Console.WriteLine("Não é possível determinar o número de carros e motos com base nos dados fornecidos.");
        }
    }
}