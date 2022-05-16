double sales, commission, total;
Console.Write("Digite o valor da venda desejada: ");
sales = double.Parse(Console.ReadLine());
Console.Write("Digite a porcentagem de comissão: ");
commission = double.Parse(Console.ReadLine());
total = sales * (commission / 100);
Console.WriteLine($"Valor total a receber de comissão: R${total}");

