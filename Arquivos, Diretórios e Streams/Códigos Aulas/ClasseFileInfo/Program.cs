using System.Runtime.CompilerServices;

string caminhoDoArquivo = GetCaminhoDoCodigoFonte();
string pasta = Path.GetDirectoryName(caminhoDoArquivo);

string caminhoOrigem= Path.Combine(pasta, "poesia.txt");
string caminhoDestino = Path.Combine(pasta, "txt", "poesia.txt");
string caminhoCopia = Path.Combine(pasta, "copia", "poesia_copia.txt");

FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);

Console.WriteLine($"Nome do arquivo: {arquivoOrigem.Name} - Caminho do Arquivo: {arquivoOrigem.FullName}");

Console.WriteLine($"O arquivo é somente leitura: {arquivoOrigem.IsReadOnly}");

var diretorioPai = arquivoOrigem.Directory;

Console.WriteLine($"Diretório pai: {diretorioPai.Name}");

Console.WriteLine($"Tamanho do arquivo: {arquivoOrigem.Length} bytes");

Console.WriteLine($"Ultima gravação: {arquivoOrigem.LastWriteTime}");

if (arquivoOrigem.Exists){
    Console.WriteLine($"Arquivo {arquivoOrigem.Name} existe, copiando para {caminhoCopia}");
    arquivoOrigem.CopyTo(caminhoCopia);

    Console.WriteLine($"Movendo arquivo {arquivoOrigem.Name} para {caminhoDestino}");
    arquivoOrigem.MoveTo(caminhoDestino);
} else{
    Console.WriteLine("Arquivo não existe");
}

static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}