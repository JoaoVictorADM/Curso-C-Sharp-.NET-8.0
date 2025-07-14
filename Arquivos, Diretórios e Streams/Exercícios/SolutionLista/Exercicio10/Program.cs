/*
10- Criar um programa que permita ao usuário mover um arquivo de um diretório para outro usando a classe File
e a classe Path. 
*/

Console.Write("Insira o caminho do arquivo de deseja mover: ");
string caminhoArquivoOrigem = Console.ReadLine();
Console.WriteLine();

if(!File.Exists(caminhoArquivoOrigem)){
    Console.WriteLine("Arquivo não encotrado");
    Environment.Exit(1);
}

Console.Write("Insira o caminho de destino do arquivo movido: ");
string caminhoArquivoDestino = Console.ReadLine();
Console.WriteLine();

try{

    File.Move(caminhoArquivoOrigem, caminhoArquivoDestino, true);

}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao mover o arquivo: {ex.Message}");
}