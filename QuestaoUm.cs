        Console.Write("Digite o primeiro número: ");
        string input1 = Console.ReadLine();

        Console.Write("Digite o segundo número: ");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double numero1) && double.TryParse(input2, out double numero2))
        {
            double media = (numero1 + numero2) / 2.0;

            Console.WriteLine($"A média aritmética dos números {numero1} e {numero2} é: {media}");
        }
        else
        {
            Console.WriteLine("Entradas inválidas. Certifique-se de inserir números válidos.");
        }
