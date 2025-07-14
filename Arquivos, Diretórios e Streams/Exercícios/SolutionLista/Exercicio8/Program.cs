/*
8- Criar um programa que permita ao usuário criar um novo diretório e, em seguida, criar um arquivo dentro
desse diretório usando a classe Directory e a classe Path. 
*/

Console.Write("Insira o caminho do diretório raiz: ");
string caminhoDiretorio = Console.ReadLine();
Console.WriteLine();

if(!Directory.Exists(caminhoDiretorio)){
    Console.WriteLine("Diretório não encontrado.");
    Environment.Exit(1);
}

Console.Write("Insira o nome do novo diretório: ");
string nomeNovoDiretorio = Console.ReadLine();  
Console.WriteLine();

try{
    string caminhoCompletoNovoDiretorio = Path.Combine(caminhoDiretorio, nomeNovoDiretorio);
    Directory.CreateDirectory(caminhoCompletoNovoDiretorio);

    Console.Write("Insira o nome do novo arquivo: ");
    string nomeNovoArquivo = Console.ReadLine();
    Console.WriteLine();

    File.Create(Path.Combine(caminhoCompletoNovoDiretorio, nomeNovoArquivo)).Close();

    Console.WriteLine($"Arquivo \"{nomeNovoArquivo}\" criado com sucesso no diretório \"{nomeNovoDiretorio}\"!");

} catch(Exception ex) {
    Console.WriteLine($"Erro ao criar diretório ou arquivo: {ex.Message}");
}