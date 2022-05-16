double c, f;
Console.Write("Digite a temperatura em graus Fahrenheit: ");
f = double.Parse(Console.ReadLine());
c = (f - 32) * 5 / 9;
Console.WriteLine($"Temperatura em Celsius: {c}ºC");
