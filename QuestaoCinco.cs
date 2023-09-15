        Console.Write("Digite o número de horas trabalhadas no mês: ");
        string inputHorasTrabalhadas = Console.ReadLine();

        Console.Write("Digite o valor recebido por hora de trabalho: ");
        string inputValorHora = Console.ReadLine();

        Console.Write("Digite o valor do salário família: ");
        string inputSalarioFamilia = Console.ReadLine();

        Console.Write("Digite o número de filhos com idade menor que 14 anos: ");
        string inputNumFilhos = Console.ReadLine();

        if (int.TryParse(inputHorasTrabalhadas, out int horasTrabalhadas) &&
            decimal.TryParse(inputValorHora, out decimal valorHora) &&
            decimal.TryParse(inputSalarioFamilia, out decimal salarioFamilia) &&
            int.TryParse(inputNumFilhos, out int numFilhosMenores))
        {
            decimal salarioBruto = (horasTrabalhadas * valorHora) + (salarioFamilia * numFilhosMenores);
            Console.WriteLine($"O salário bruto a ser recebido é: {salarioBruto:C}");
        }
        else
        {
            Console.WriteLine("Inválido. Insira valores válidos.");
        }