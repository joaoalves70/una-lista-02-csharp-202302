
        Console.Write("Digite o primeiro número: ");
        string inputNumero1 = Console.ReadLine();

        Console.Write("Digite o segundo número (a base): ");
        string inputNumero2 = Console.ReadLine();

        if (double.TryParse(inputNumero1, out double numero1) && double.TryParse(inputNumero2, out double numero2))
        {
            if (numero2 > 0)
            {
                double resultado = Math.Log(numero1, numero2);

                Console.WriteLine($"O logaritmo de {numero1} na base {numero2} é: {resultado:F4}");
            }
            else
            {
                Console.WriteLine("A base deve ser maior do que zero para calcular o logaritmo.");
            }
        }
        else
        {
            Console.WriteLine("Inválido. Insira valores válidos.");
        }