/*
5- Escreva um programa que leia o conteúdo de um arquivo de imagem e converta-o para um arquivo de texto
usando o algoritmo de codificação Base64. Em seguida, salve o arquivo de texto em um novo arquivo. O
nome do arquivo de origem e destino deve ser fornecido pelo usuário.
*/

Console.Write("Insira o caminho do arquivo(imagem) de origem: ");
string caminhoArquivoOrigem = Console.ReadLine();
Console.WriteLine();

if(!File.Exists(caminhoArquivoOrigem)){
    Console.WriteLine("Arquivo não encontrado.");
    Environment.Exit(1);
}

Console.Write("Insira o caminho de destin do arquivo: ");
string caminhoArquivoDestino = Console.ReadLine();
Console.WriteLine();

FileInfo newFile = new FileInfo(caminhoArquivoDestino);
if(!newFile.Exists)
    newFile.Create().Close();

using StreamReader reader = new StreamReader(caminhoArquivoOrigem);
using StreamWriter writer = new StreamWriter(caminhoArquivoDestino);

byte[] imagemBytes = File.ReadAllBytes(caminhoArquivoOrigem);

string imagemBase64 = Convert.ToBase64String(imagemBytes);

writer.WriteLine(imagemBase64);
Console.WriteLine("Arquivo convertido com sucesso!");

Console.WriteLine("Conteúdo do arquivo convertido:");