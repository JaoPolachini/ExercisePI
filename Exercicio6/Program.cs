double H, IdW;
Console.Write("Digite a altura desejada: ");
H = double.Parse(Console.ReadLine());
IdW = (72.7 * H) - 58;
Console.Write($"O peso ideal para esta altura é: KG {IdW}");
