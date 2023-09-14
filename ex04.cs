using System;
// Escreva um algoritmo para calcular os juros compostos de uma aplicação financeira. 
// O algoritmo deve ler o valor do capital a ser aplicado, o prazo de aplicação em meses, 
// a taxa de juros mensal e apresentar na tela o montante a ser recebido.
// OBS: M = C × (1 + i) n,  em que M é o montante a ser recebido, C é o capital aplicado, 
// i é a taxa de juros e n é o prazo da aplicação.
public class Program
{
	public static void Main()
	{
		decimal c = 0; //capital
		decimal i = 0; //juros
		decimal n = 0; //prazo da p=aplicação
		decimal m = 0; // valor final
		
Console.WriteLine("Digite quanto quer aplicar:  "); 
c = decimal.Parse(Console.ReadLine());
Console.Write("Por quanto tempo você quer deixar esse valor aplicado?");
n = decimal.Parse(Console.ReadLine());
m = c * (1 + i) * n ;

		
Console.Write("O montante a ser recebido é: " + m.ToString("N1"));
Console.ReadKey();
		
	}
}