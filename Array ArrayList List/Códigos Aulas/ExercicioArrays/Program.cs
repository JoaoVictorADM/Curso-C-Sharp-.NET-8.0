int numeroAlunos = 5;
double media = 0;

string[] nomes = new string[5];
double[] notas = new double[5];

for(int i = 0; i < numeroAlunos; i++){
    Console.Write("Digite o nome do aluno: ");
    nomes[i] = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Digite a nota do aluno: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    media += notas[i]/numeroAlunos;

}

for(int i = 0; i < numeroAlunos; i++)
    Console.WriteLine($"Aluno {nomes[i]} - Nota: {notas[i]}");

Console.WriteLine($"\nMédia das notas: {media}");

