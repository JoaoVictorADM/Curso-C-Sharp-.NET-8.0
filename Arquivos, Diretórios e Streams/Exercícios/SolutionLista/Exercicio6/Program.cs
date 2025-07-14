/*
6- Criar um programa que liste todos os arquivos em um determinado diretório usando a classe Directory e a
classe Path.
*/

Console.Write("Insira o caminho do diretório: ");
string caminhoDiretorio = Console.ReadLine();
Console.WriteLine();

if(!Directory.Exists(caminhoDiretorio)){
    Console.WriteLine("Diretório não encontrado.");
    Environment.Exit(1);
}

foreach (var arquivo in Directory.GetFiles(caminhoDiretorio)){
    Console.WriteLine($"Arquivo: {arquivo}");
}
