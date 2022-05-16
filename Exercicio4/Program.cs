double c, f;
Console.Write("Digite a temperatura em graus Celsius: ");
c = double.Parse(Console.ReadLine());
f = (9 * c + 160) / 5;
Console.WriteLine($"Temperatura em Fahrenheit: {f}ºF");