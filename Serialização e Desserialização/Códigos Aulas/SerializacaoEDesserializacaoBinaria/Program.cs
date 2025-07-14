using SerializacaoEDesserializacaoBinaria;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

public class Program
{
    public static void Main(string[] args){

        Aluno aluno1 = new(101, "Maria", "maria@gmail.com", 20);

        var caminhoArquivo = Path.Combine(Path.GetDirectoryName(GetCaminhoDoCodigoFonte()), "AlunoSerializado.bin");

        using (FileStream stream = new FileStream(caminhoArquivo, FileMode.OpenOrCreate, FileAccess.ReadWrite)){

            #pragma warning disable SYSLIB0011
            var bf = new BinaryFormatter();
            bf.Serialize(stream, aluno1);

            stream.Seek(0, SeekOrigin.Begin);
            var alunoDesserializado = (Aluno)bf.Deserialize(stream);
            Console.WriteLine(alunoDesserializado.ToString());

        }



    }

    private static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
        return caminho;
    }
}

