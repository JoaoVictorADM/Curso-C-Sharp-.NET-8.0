/*
4- Escreva um programa que leia o conteúdo de um arquivo de texto e o criptografe usando o algoritmo de
criptografia AES. Em seguida, salve o arquivo criptografado em um novo arquivo. O nome do arquivo de
origem e destino deve ser fornecido pelo usuário. 
*/

using System.Security.Cryptography;

Console.Write("Insira o caminho do arquivo de origem: ");
string caminhoArquivoOrigem = Console.ReadLine();
Console.WriteLine();    

if(!File.Exists(caminhoArquivoOrigem)){
    Console.WriteLine("Arquivo não encontrado.");
    Environment.Exit(1);
}

Console.Write("Insira o caminho do arquivo criptografado de destino: ");
string caminhoArquivoDestino = Console.ReadLine();
Console.WriteLine();

using StreamReader reader = File.OpenText(caminhoArquivoOrigem);

FileInfo newFile = new FileInfo(caminhoArquivoDestino);
if(!newFile.Exists)
    newFile.Create().Close();

using StreamWriter writer = new StreamWriter(caminhoArquivoDestino);

string linha;

while((linha = reader.ReadLine()) != null){
    string linhaCriptografada = Criptografar(linha);
    writer.WriteLine(linhaCriptografada);
}

Console.WriteLine("Arquivo criptografado com sucesso!");

static string Criptografar(string texto){
    using Aes aes = Aes.Create();

    aes.GenerateKey();
    aes.GenerateIV();

    byte[] chave = aes.Key;
    byte[] iv = aes.IV;

    using MemoryStream ms = new MemoryStream();
    using CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);
    using StreamWriter sw = new StreamWriter(cs);

    sw.Write(texto);
    sw.Flush();
    cs.FlushFinalBlock(); 

    byte[] encrypted = ms.ToArray();
    return Convert.ToBase64String(encrypted);
}
