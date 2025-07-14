/*
9- Criar um programa que permita ao usuário copiar um arquivo de um diretório para outro usando a classe File
e a classe Path. 
*/

Console.Write("Insira o caminho do arquivo de deseja copiar: ");
string caminhoArquivoOrigem = Console.ReadLine();
Console.WriteLine();

if(!File.Exists(caminhoArquivoOrigem)){
    Console.WriteLine("Arquivo não encotrado");
    Environment.Exit(1);
}

Console.Write("Insira o caminho de destino do arquivo copiado: ");
string caminhoArquivoDestino = Console.ReadLine();
Console.WriteLine();

try{

    File.Copy(caminhoArquivoOrigem, caminhoArquivoDestino, true);

} catch (Exception ex){
    Console.WriteLine($"Erro ao copiar o arquivo: {ex.Message}");
}
