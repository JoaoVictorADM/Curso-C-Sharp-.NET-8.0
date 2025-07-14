/*
12- Criar um programa que permita ao usuário excluir um arquivo ou diretório usando a classe Directory, a
classe DirectoryInfo e a classe Path.
*/

Console.Write("Insira o caminho do arquivo de deseja deletar: ");
string caminhoArquivoOrigem = Console.ReadLine();
Console.WriteLine();

if(!File.Exists(caminhoArquivoOrigem)){
    Console.WriteLine("Arquivo não encotrado");
    Environment.Exit(1);
}

File.Delete(caminhoArquivoOrigem);

Console.Write("Insira o caminho do diretório: ");
string caminhoDiretorio = Console.ReadLine();
Console.WriteLine();

if(!Directory.Exists(caminhoDiretorio)){
    Console.WriteLine("Diretório não encontrado.");
    Environment.Exit(1);
}

Directory.Delete(caminhoDiretorio, true);