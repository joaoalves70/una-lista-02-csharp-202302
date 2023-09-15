        Console.Write("Digite o valor do capital a ser aplicado: ");
        string inputCapital = Console.ReadLine();

        Console.Write("Digite o prazo da aplicação em meses: ");
        string inputPrazo = Console.ReadLine();

        Console.Write("Digite a taxa de juros mensal (em decimal): ");
        string inputTaxaJuros = Console.ReadLine();

        if (decimal.TryParse(inputCapital, out decimal capital) &&
            int.TryParse(inputPrazo, out int prazo) &&
            decimal.TryParse(inputTaxaJuros, out decimal taxaJuros))
        {
            decimal montante = capital * (decimal)Math.Pow((double)(1 + taxaJuros), prazo);
            Console.WriteLine($"O montante a ser recebido é: {montante:C}");
        }
        else
        {
            Console.WriteLine("Inválido. Insira valores válidos.");
        }
