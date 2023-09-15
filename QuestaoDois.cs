
        Console.Write("Informe o valor do produto: ");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal preco))
        {
            decimal novoPreco = preco * 1.1m;
            Console.WriteLine($"Novo valor do produto: {novoPreco:C}");
        else
        {
            Console.WriteLine("Inválido. Insira um número válido.");
        }
