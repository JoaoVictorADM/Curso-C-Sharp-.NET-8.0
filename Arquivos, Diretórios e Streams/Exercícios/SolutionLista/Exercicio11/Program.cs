/*
11- Criar um programa que liste todos os arquivos em um determinado diretório e suas subpastas usando a
classe DirectoryInfo e a classe Path. 
*/

Console.Write("Insira o caminho do diretório: ");
string caminhoDiretorio = Console.ReadLine();
Console.WriteLine();

if(!Directory.Exists(caminhoDiretorio)){
    Console.WriteLine("Diretório não encontrado.");
    Environment.Exit(1);
}

DirectoryInfo dir = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine("Subdiretórios: ");

foreach (var subDir in dir.GetDirectories()){
    Console.WriteLine($"\tSubdiretório: {subDir.Name}");
}

Console.WriteLine("Arquivos: ");

foreach(var arquivo in dir.GetFiles()){
    Console.WriteLine($"\tArquivo: {arquivo.Name}");
}