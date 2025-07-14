/*
2- Escreva um programa que copie um arquivo de um diretório para outro. O nome e o caminho do arquivo de
origem e destino devem ser fornecidos pelo usuário.
*/

Console.Write("Insira o caminho do arquivo de deseja copiar: ");
string caminhoArquivoOrigem = Console.ReadLine();
Console.WriteLine();

if (!File.Exists(caminhoArquivoOrigem)){
    Console.WriteLine("Arquivo não encotrado");
    Environment.Exit(1);
}

Console.Write("Insira o caminho de destino do arquivo copiado: ");
string caminhoArquivoDestino = Console.ReadLine();
Console.WriteLine();

try{
     
    File.Copy(caminhoArquivoOrigem, caminhoArquivoDestino, true);

} catch(Exception ex){
    Console.WriteLine($"Erro ao copiar o arquivo: {ex.Message}");
}
