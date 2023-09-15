Console.Write("Digite o primeiro valor: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        double c = double.Parse(Console.ReadLine());


        double mediaAritmetica = (a + b + c) / 3;


        double mediaHarmonica = 3.0 / ((1.0 / a) + (1.0 / b) + (1.0 / c));


        double mediaGeometrica = Math.Pow(a * b * c, 1.0 / 3.0);

        
        Console.WriteLine($"Média Aritmética: {mediaAritmetica:F2}");
        Console.WriteLine($"Média Harmônica: {mediaHarmonica:F2}");
        Console.WriteLine($"Média Geométrica: {mediaGeometrica:F2}");