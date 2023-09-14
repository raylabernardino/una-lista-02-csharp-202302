
        // leia o numero digitado
        int segundos = int.Parse(Console.ReadLine());

        // converta os numeros em horas e minutos
        int horas = segundos / 3600;
        int minutos = (segundos % 3600) / 60;
        int segundosRestantes = segundos % 60;

        // mostre o resultado
        Console.WriteLine($"{horas}:{minutos:00}:{segundosRestantes:00}");