        Console.Write("Digite o total de veículos: ");
        int totalVeiculos = int.Parse(Console.ReadLine());

        Console.Write("Digite o total de rodas: ");
        int totalRodas = int.Parse(Console.ReadLine());

        int numCarros = totalRodas / 4;

        int rodasRestantes = totalRodas - (numCarros * 4);

        int numMotos = rodasRestantes / 2;

        Console.WriteLine($"Número de carros: {numCarros}");
        Console.WriteLine($"Número de motos: {numMotos}");