double a, b, result;
Console.WriteLine("Digite o valor de A: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de B: ");
b = double.Parse(Console.ReadLine());

result = a % b;

Console.WriteLine($"Resultado da operação: {result}");

if (result == 0)
{
    Console.WriteLine("A divisão dos valores informados não apresentou valor restante");
}
