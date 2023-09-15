        Console.Write("Digite o número de segundos: ");
        int totalSegundos = int.Parse(Console.ReadLine());

        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;

        Console.WriteLine($"Horas: {horas}, Minutos: {minutos}, Segundos: {segundos}");
