double euro, value1, real;
Console.Write("Digite a cotacao do euro desejada - R$5,29(16/05/22): ");
euro = double.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de euros que queira comprar: ");
value1 = double.Parse(Console.ReadLine());
real = euro * value1;
Console.WriteLine($"Valor convertido: R${real}");

