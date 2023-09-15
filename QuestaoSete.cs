
        Console.Write("Digite o salário fixo do vendedor: ");
        string inputSalarioFixo = Console.ReadLine();

        Console.Write("Digite o valor total das vendas realizadas no mês: ");
        string inputValorVendas = Console.ReadLine();

        Console.Write("Digite o percentual de comissão (em decimal): ");
        string inputPercentualComissao = Console.ReadLine();

        if (decimal.TryParse(inputSalarioFixo, out decimal salarioFixo) &&
            decimal.TryParse(inputValorVendas, out decimal valorVendas) &&
            decimal.TryParse(inputPercentualComissao, out decimal percentualComissao))
        {
            decimal salarioTotal = salarioFixo + (valorVendas * percentualComissao);

            Console.WriteLine($"O salário total do vendedor é: {salarioTotal:C}");
        }
        else
        {
            Console.WriteLine("Inválido. Insira valores válidos.");
        }