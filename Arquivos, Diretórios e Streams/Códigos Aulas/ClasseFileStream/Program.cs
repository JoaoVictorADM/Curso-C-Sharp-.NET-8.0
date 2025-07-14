using System;
using System.Runtime.CompilerServices;

string caminhoDoArquivo = GetCaminhoDoCodigoFonte();
string pasta = Path.GetDirectoryName(caminhoDoArquivo);

string caminhoArquivo = Path.Combine(pasta, "poesia.txt");

FileStream fs = null;
StreamReader reader = null;

try{

    fs = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.Read);
    reader = new StreamReader(fs);

    string? linha;
    while ((linha = reader.ReadLine()) != null){
        Console.WriteLine(linha);
    }

} catch(IOException ex){
    Console.WriteLine($"Erro: {ex.Message}");
} catch (Exception ex){
    Console.WriteLine($"Erro: {ex.Message}");
}
finally{
    if(fs != null) fs.Close();
    if(reader != null) reader.Close();
}

static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}