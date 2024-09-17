string[,] alunos = new string[2, 5];

for(int i = 0; i < alunos.GetLength(0); i++){
    for(int j = 0; j < alunos.GetLength(1); j++){
        Console.Write($"Digite o nome do aluno a[{i}, {j}]: ");
        alunos[i, j] = Console.ReadLine();
        Console.WriteLine();
    }
}

Console.WriteLine();

for(int i = 0; i < alunos.GetLength(0); i++){
    for(int j = 0; j < alunos.GetLength(1); j++){
        Console.Write($"|Aluno a[{i}, {j}]: {alunos[i, j]} |");
    }
    Console.WriteLine();
}