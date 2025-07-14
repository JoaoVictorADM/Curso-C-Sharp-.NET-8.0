
using Exercicio;
using System.Runtime.CompilerServices;
using System.Text.Json;

List<Aluno> alunos = new List<Aluno>{
    new Aluno(1, "João", "joao@gmail.com", 20),
    new Aluno(2, "Maria", "maria@gmail.com", 19),
    new Aluno(3, "Pedro", "pedro@gmail.com", 18)
};

string pastaPai = Path.GetDirectoryName(GetCaminhoDoCodigoFonte());

var caminhoArquivoJson = Path.Combine(pastaPai, "listaAlunos.json");
var caminhoArquivoXml = Path.Combine(pastaPai, "listaAlunos.xml");

using(StreamWriter writerJson = new StreamWriter(caminhoArquivoJson)){
    string json = JsonSerializer.Serialize(alunos);
    writerJson.WriteLine(json);
    Console.WriteLine("Lista serializada para json");
}

using(StreamWriter writerXml = new StreamWriter(caminhoArquivoXml)){
    var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Aluno>));
    xmlSerializer.Serialize(writerXml, alunos);
    Console.WriteLine("Lista serializada para xml");
}
static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}