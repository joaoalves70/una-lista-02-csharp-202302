
        Console.Write("Digite a temperatura em graus Fahrenheit: ");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal temperaturaFahrenheit))
        {
            decimal temperaturaCelsius = (temperaturaFahrenheit - 32) / 1.8m;

            Console.WriteLine($"A temperatura em graus Celsius é: {temperaturaCelsius:F2} °C");
        }
        else
        {
            Console.WriteLine("Inválido. Insira valores válidos.");
        }