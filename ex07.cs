//Escreva um algoritmo que leia o salário fixo de um vendedor, o valor total das
//vendas que ele realizou no mês e o percentual que ele ganha sobre o total das
//vendas mensais. O algoritmo deve calcular o salário total do vendedor e apresentá-lo na tela.

public class Program
{
	public static void Main()
	{
		double salario = 0;
		double totalVendas = 0;
		double percentualVendas = 0;
		double salarioTotal =0;
		
Console.WriteLine("Digite o salário fixo:  "); 
salario = double.Parse(Console.ReadLine());
Console.WriteLine("Digite Quantas vendas você realizou esse mês:  "); 
totalVendas = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o percentual das vendas:  "); 
percentualVendas = double.Parse(Console.ReadLine());
salarioTotal = salario + (percentualVendas * totalVendas) ;		
Console.Write("O seu salário total esse mes será de: " + salarioTotal.ToString("N1"));
		
	}
}