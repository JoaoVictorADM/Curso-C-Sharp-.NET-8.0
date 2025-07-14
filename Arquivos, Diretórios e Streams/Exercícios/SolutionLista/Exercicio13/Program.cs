/*
13- Criar um programa que renomeie um arquivo usando a classe File e a classe Path. 
*/

Console.Write("Insira o caminho do arquivo de deseja renomear: ");
string caminhoArquivoOrigem = Console.ReadLine();
Console.WriteLine();

if(!File.Exists(caminhoArquivoOrigem)){
    Console.WriteLine("Arquivo não encotrado");
    Environment.Exit(1);
}

Console.Write("Insira o nome nome do arquivo: ");
string novoNomeArquivo = Console.ReadLine();
Console.WriteLine();

string caminhaPastaPai = Path.GetDirectoryName(caminhoArquivoOrigem);

File.Move(caminhoArquivoOrigem, Path.Combine(caminhaPastaPai, novoNomeArquivo), true);
