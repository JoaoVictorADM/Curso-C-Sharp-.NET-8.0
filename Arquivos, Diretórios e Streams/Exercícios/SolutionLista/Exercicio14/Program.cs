/*
14- Criar um programa que retorne o tamanho total de um diretório, incluindo todos os arquivos e
subdiretórios, usando a classe Directory e a classe Path.
*/

Console.Write("Insira o caminho do diretório: ");
string caminhoDiretorio = Console.ReadLine();
Console.WriteLine();

if(!Directory.Exists(caminhoDiretorio)){
    Console.WriteLine("Diretório não encontrado.");
    Environment.Exit(1);
}

DirectoryInfo dir = new DirectoryInfo(caminhoDiretorio);

Console.WriteLine($"Tamanho do diretório: {CalcularTamanhoDiretorio(dir)} bytes");

static int CalcularTamanhoDiretorio(DirectoryInfo dir){
    
    int tamanho = 0;

    foreach(var arquivo in dir.GetFiles()){
        tamanho += (int)arquivo.Length;
    }

    foreach(var subDir in dir.GetDirectories()){
        tamanho += CalcularTamanhoDiretorio(subDir);
    }

    return tamanho;

}