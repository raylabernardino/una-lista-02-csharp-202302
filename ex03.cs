//Escreva um algoritmo que leia uma temperatura fornecida pelo usuário a partir do teclado em graus Fahrenheit 
//e a converta para o seu equivalente em graus centígrados.
//OBS.: °C = (°F − 32) / 1,8

public class Program
{
	public static void Main()
	{
		double f = 0;
		double c = 0;
		
Console.WriteLine("Digite a temperatura na escala Fahrenheit:  "); 
f = double.Parse(Console.ReadLine());
c = (double) (f - 32) / 1.8;
		
Console.Write("A temperatura convertida em Celsius é: " + c.ToString("N0"));
Console.ReadKey();
		
	}
}