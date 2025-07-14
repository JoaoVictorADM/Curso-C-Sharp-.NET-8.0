using System.Runtime.CompilerServices;

string caminhoDoArquivo = GetCaminhoDoCodigoFonte();
string pasta = Path.GetDirectoryName(caminhoDoArquivo);
var caminhoDiretorio = Path.Combine(pasta, "NovoDiretorio");
var caminhoDiretorio2 = Path.Combine(pasta, @"NovoDiretorio2\Teste");

Console.WriteLine($"Criando um novo diretório em {caminhoDiretorio2}");

try{

    if(!Directory.Exists(caminhoDiretorio2)){
        Directory.CreateDirectory(caminhoDiretorio2);
        Console.WriteLine("Diretório criado com sucesso!");
    } else{
        Console.WriteLine("O diretório já existe.");
    }

} catch(Exception ex){
    Console.WriteLine($"Erro ao criar o diretório: {ex.Message}");
}

Console.WriteLine($"Excluindo diretório em {caminhoDiretorio}");

try{

    if(Directory.Exists(caminhoDiretorio)){
        Directory.Delete(caminhoDiretorio, true);
        Console.WriteLine("Diretório deltado com sucesso!");
    } else{
        Console.WriteLine("O diretório não existe.");
    }

} catch (Exception ex){
    Console.WriteLine($"Erro ao deletar o diretório: {ex.Message}");
}

string[] subDiretorios = Directory.GetDirectories(pasta);
foreach(var subDiretorio in subDiretorios){
    Console.WriteLine($"Subdiretório encontrado: {subDiretorio}");
}
static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}