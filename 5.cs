using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Quantas horas trabalhou em um mês?");
		string horasTrabalhadas = Console.ReadLine();
        Console.WriteLine("Qual o seu pagamento por hora trabalhada?");
		string valorHora = Console.ReadLine();
        Console.WriteLine("Quantos filhos com a idade menor que 14 anos você tem?");
		string numFilhos = Console.ReadLine();
        Console.WriteLine("Qual o valor atual do salário família por filho?");
        string salarioFamilia = Console.ReadLine();
		
		double horasTrabalhadasNum = double.Parse(horasTrabalhadas);
        double valorHoraNum = double.Parse(valorHora);
        double numFilhosNum = double.Parse(numFilhos);
        double salarioFamiliaNum = double.Parse(salarioFamilia);

        double salarioBruto = 0.0;
        double salarioBase = horasTrabalhadasNum * valorHoraNum;
		
        Console.Write ("\r\n");
        Console.Write ("=========================================================================================================\r\n");
        Console.Write ("\r\n");

		if (salarioBase <= 1754.18) {
            salarioBruto = salarioBase + numFilhosNum * salarioFamiliaNum;
            Console.WriteLine("O salário bruto é de R$" + salarioBruto + "!\r\n");
        } else {
            Console.WriteLine("O salário bruto é de R$" + salarioBase + "!\r\n");
            Console.WriteLine("");
            Console.WriteLine("OBS: Você não possui direito ao salário família, portanto ele não entrou no cálculo.\r\n");
        }

        Console.Write ("=========================================================================================================");
	}
}