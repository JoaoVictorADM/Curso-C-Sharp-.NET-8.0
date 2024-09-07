/*
 
3 - Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).

 
*/

float[,] notas = new float[2, 5];

for(int i = 0; i < notas.GetLength(0); i++){
    for(int j = 0; j < notas.GetLength(1); j++){
        Console.Write($"Infome a nota do aluno[{i}, {j}]: ");
        notas[i, j] = float.Parse(Console.ReadLine());
    }
}

for(int i = 0; i < notas.GetLength(0); i++){
    double media = 0.0;
    for(int j = 0; j < notas.GetLength(1); j++)
        media += notas[i, j];
    Console.WriteLine($"Média grupo {i + 1}: {media/notas.GetLength(1)}\n");
}