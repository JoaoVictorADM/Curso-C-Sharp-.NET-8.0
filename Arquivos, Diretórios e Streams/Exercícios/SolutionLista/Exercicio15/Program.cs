/*
15 - Criar um programa que retorne o nome do arquivo mais recente em um diretório usando a classe
DirectoryInfo e a classe Path. 
*/

using System.Runtime;

Console.Write("Insira o caminho do diretório: ");
string caminhoDiretorio = Console.ReadLine();
Console.WriteLine();

if (!Directory.Exists(caminhoDiretorio)){
    Console.WriteLine("Diretório não encontrado.");
    Environment.Exit(1);
}

DirectoryInfo dir = new DirectoryInfo(caminhoDiretorio);

DateTime? lastWrite = null;
FileInfo? arquivoMaisRecente = null;

foreach(var arquivo in dir.GetFiles("*", SearchOption.AllDirectories)){
    if(lastWrite == null){
        arquivoMaisRecente = arquivo;
        lastWrite = arquivo.LastWriteTime;
        continue;
    }

    if(arquivo.LastWriteTime > lastWrite){
        arquivoMaisRecente = arquivo;
        lastWrite = arquivo.LastWriteTime;
    }
}

Console.WriteLine($"Arquivo mais recentemente modificado: {arquivoMaisRecente.FullName} - Data: {lastWrite}");

