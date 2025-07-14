using SerializacaoEDesserializacaoJSON;
using System.Runtime.CompilerServices;
using System.Text.Json;

Aluno aluno1 = new Aluno(1, "João", "joao@gmail.com", 20);

var caminhoArquivo = Path.Combine(Path.GetDirectoryName(GetCaminhoDoCodigoFonte()), "AlunoSerializado.json");

using (FileStream fileStream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite)){
    JsonSerializer.Serialize(fileStream, aluno1);
    Console.WriteLine("Objeto Serializado");

}

string jsonContent = File.ReadAllText(caminhoArquivo);

var alunoDesserializado = JsonSerializer.Deserialize<Aluno>(jsonContent);

Console.WriteLine("Objeto Desserializado");
Console.WriteLine(alunoDesserializado.ToString());

static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}