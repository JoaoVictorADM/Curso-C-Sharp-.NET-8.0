/*
7- Criar um programa que liste todos os subdiretórios em um determinado diretório usando a classe
DirectoryInfo. 
*/

Console.Write("Insira o caminho do diretório: ");
string caminhoDiretorio = Console.ReadLine();
Console.WriteLine();

if (!Directory.Exists(caminhoDiretorio)){
    Console.WriteLine("Diretório não encontrado.");
    Environment.Exit(1);
}

DirectoryInfo dir = new DirectoryInfo(caminhoDiretorio);

foreach(var subDir in dir.GetDirectories()){
    Console.WriteLine($"Subdiretório: {subDir.Name}");
}



