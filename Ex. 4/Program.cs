Console.Write("Digite a quantidade alunos que quer ler: ");

int numAlunos = int.Parse(Console.ReadLine());
double[] notasG1 = new double[numAlunos];
double[] notasG2 = new double[numAlunos];
double[] medias = new double[numAlunos];

for (int i = 0; i < numAlunos; i++)
{
    Console.Write($"Digite a nota G1 do {i + 1}º aluno: ");
    notasG1[i] = double.Parse(Console.ReadLine());

    Console.Write($"Digite a nota G2 do {i + 1}º aluno: ");
    notasG2[i] = double.Parse(Console.ReadLine());

    medias[i] = (notasG1[i] + notasG2[i]) / 2;
}

Console.WriteLine("Notas dos alunos:");
for (int i = 0; i < numAlunos; i++)
{
    Console.WriteLine($"Aluno {i + 1}: G1={notasG1[i]}, G2={notasG2[i]}, Média={medias[i]}");
}