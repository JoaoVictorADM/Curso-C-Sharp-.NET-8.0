using SerializacaoEDesserializacaoXML;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

Aluno aluno1 = new Aluno(1, "João", "joao@gmail.com", 20);

var caminhoArquivo = Path.Combine(Path.GetDirectoryName(GetCaminhoDoCodigoFonte()), "AlunoSerializado.xml");

XmlSerializer xmlSerializer = new XmlSerializer(typeof(Aluno));

using(StreamWriter streamWriter = new StreamWriter(caminhoArquivo)){
    xmlSerializer.Serialize(streamWriter, aluno1);
}

Console.WriteLine("Arquivo serializado");

using (StreamReader streamReader = new StreamReader(caminhoArquivo)){
    var alunoDesserializado = (Aluno)xmlSerializer.Deserialize(streamReader);
    Console.WriteLine("Arquivo desserializado");
    Console.WriteLine(alunoDesserializado.ToString());
}

static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
    return caminho;
}
