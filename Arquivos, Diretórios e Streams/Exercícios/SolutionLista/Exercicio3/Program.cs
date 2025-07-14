/*
3- Escreva um programa que crie um arquivo e escreva algumas informações nele. Em seguida, abra o arquivo
novamente e adicione mais algumas informações a ele. Em seguida, leia o conteúdo do arquivo e exiba-o na
tela. 
*/

using System.Runtime.CompilerServices;

string caminhoDoArquivo = GetCaminhoDoCodigoFonte();
string pasta = Path.GetDirectoryName(caminhoDoArquivo);
string caminhoCompleto = Path.Combine(pasta, "informacoes.txt");

try{
    FileInfo file = new FileInfo(caminhoCompleto);

    if(!file.Exists)
        file.Create().Close(); ;

    using StreamWriter writer = file.AppendText();

    writer.WriteLine("Informações iniciais do arquivo.");
    writer.WriteLine("Adicionando mais informações ao arquivo.");
    writer.WriteLine("Este é o conteúdo final do arquivo.");

} catch(Exception ex){
    Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
}

try{
    FileInfo file = new FileInfo(caminhoCompleto);

    if(!file.Exists)
        file.Create();

    using(StreamWriter writer = file.AppendText()){
        writer.WriteLine("Adicionando mais informações ao arquivo.");
    }

    using (StreamReader reader = file.OpenText()){
        Console.WriteLine("Conteúdo do arquivo:");

        string linha;

        while ((linha = reader.ReadLine()) != null)
        {
            Console.WriteLine(linha);
        }
    }

} catch(Exception ex){
    Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
}

static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}