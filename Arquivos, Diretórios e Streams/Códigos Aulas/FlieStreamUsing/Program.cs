using System.Runtime.CompilerServices;

string caminhoDoArquivo = GetCaminhoDoCodigoFonte();
string pasta = Path.GetDirectoryName(caminhoDoArquivo);

string caminhoArquivo = Path.Combine(pasta, "poesia.txt");

try{
    using(FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read)){
        using(StreamReader reader = new StreamReader(fs)){
            string? linha;

            while((linha = reader.ReadLine()) != null){
                Console.WriteLine(linha);
            }
        }
    }
} catch(IOException ex){
    Console.WriteLine($"Erro: {ex.Message}");
} catch (Exception ex){
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine();

try{
    using FileStream fs = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read);

    //using StreamReader reader = new StreamReader(fs);
    using StreamReader reader = File.OpenText(caminhoArquivo);

    string? linha;

    while((linha = reader.ReadLine()) != null){
        Console.WriteLine(linha);
    }

} catch (IOException ex){
    Console.WriteLine($"Erro: {ex.Message}");
} catch (Exception ex){
    Console.WriteLine($"Erro: {ex.Message}");
}


static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}