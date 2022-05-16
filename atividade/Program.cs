int y1, y2, media;
Console.Write("Digite a idade do aluno mais novo: ");
y1 = int.Parse(Console.ReadLine());
Console.Write("Digite a idade do aluno mais valor: ");
y2 = int.Parse(Console.ReadLine());
media = (y1 + y2) / 2;
Console.WriteLine($"Aluno mais novo {y1}");
Console.WriteLine($"Aluno mais velho {y2}");
Console.WriteLine($"Idade media dos alunos da classe: {media}");


