double[] N = new double[4];
int v = 4;

for (v = 0; v < 4; v++)
{
    Console.Write($"Digite a nota {v + 1}: ");
    N[v] = double.Parse(Console.ReadLine());


}

double media = (N[0] + N[1] + N[2] + N[3]) / v;
Console.WriteLine($"A média das notas digitadas é: {media}");

if (media < 7)
{
    Console.WriteLine("Aluno Reprovado");
}

if (media >= 7)
{
    Console.WriteLine("Aluno Aprovado");
}
