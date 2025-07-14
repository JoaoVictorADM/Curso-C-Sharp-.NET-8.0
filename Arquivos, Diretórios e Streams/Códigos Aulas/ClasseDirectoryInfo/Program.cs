using System.Runtime.CompilerServices;

string caminhoDoArquivo = GetCaminhoDoCodigoFonte();
string pasta = Path.GetDirectoryName(caminhoDoArquivo);

string caminhoDiretorio = Path.Combine(pasta, "NovoDiretorio");

var dir = new DirectoryInfo(caminhoDiretorio);

if(!dir.Exists){
    Console.WriteLine($"Criando diretorio em {caminhoDiretorio}");
    dir.Create();
}

Console.WriteLine();

Console.WriteLine($"Nome do diretorio: {dir.Name}");
Console.WriteLine($"Caminho completo do diretorio: {dir.FullName}");
Console.WriteLine($"Data de criação do diretorio: {dir.CreationTime}");
Console.WriteLine($"Ultimo acesso ao diretorio: {dir.LastAccessTime}");
Console.WriteLine($"Ultima escrita no diretorio: {dir.LastWriteTime}");
Console.WriteLine($"Atributos do diretorio: {dir.Attributes}");

Console.WriteLine();

/*try
{

    Console.WriteLine($"Excluindo diretorio em {caminhoDiretorio}");

    if(dir.Exists){
        dir.Delete(true);
        Console.WriteLine("Diretório deletado com sucesso!");
    } else{
        Console.WriteLine("O diretório não existe.");
    }

} catch(Exception ex){
    Console.WriteLine($"Erro: {ex.Message}");
}*/

Console.WriteLine();

if (!dir.Exists){
    Console.WriteLine($"Criando diretorio em {caminhoDiretorio}");
    dir.Create();
}

Console.WriteLine();

try
{

    Console.WriteLine("Criando subdiretorios");

    if(dir.Exists){

        dir.CreateSubdirectory("SubDiretorio1");
        dir.CreateSubdirectory("SubDiretorio2");

    }
    else {
        Console.WriteLine("Diretório não existe, criando...");
    }


} catch(Exception ex){
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine();

Console.WriteLine("Listando subdiretorios");

DirectoryInfo[] subDiretorios = dir.GetDirectories();
foreach(var subDiretorio in subDiretorios){
    Console.WriteLine($"Subdiretório encontrado: {subDiretorio.Name}");
}

Console.WriteLine();

Console.WriteLine("Listando Arquivos");

foreach(var arquivo in dir.GetFiles()){
    Console.WriteLine($"Arquivo encontrado: {arquivo.Name}");
}

static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}