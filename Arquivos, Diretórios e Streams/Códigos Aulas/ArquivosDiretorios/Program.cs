using System.Runtime.CompilerServices;

class Program{
    static void Main(){
        string caminhoDoArquivo = GetCaminhoDoCodigoFonte();
        string pasta = Path.GetDirectoryName(caminhoDoArquivo);
        string caminhoFinal = Path.Combine(pasta, "arquivo1.txt");

        //File.Create(caminhoFinal).Close();
        //Console.WriteLine("Arquivo criado em: " + caminhoFinal);

        File.WriteAllText(caminhoFinal, "João Victor\r\n");

        string novoTexto = "João Victor" +
                           Environment.NewLine +   
                           "20 anos\r\n" +
                           "C#";

        File.AppendAllText(caminhoFinal, novoTexto);

        Console.WriteLine();

        Console.WriteLine("Lendo o conteudo do arquivo:\n");
        string conteudo = File.ReadAllText(caminhoFinal);
        Console.WriteLine(conteudo);

        Console.WriteLine();

        Console.WriteLine($"Última modificação feita em: {File.GetLastWriteTime(caminhoFinal)}");
        Console.WriteLine($"Último acesso feito em: {File.GetLastAccessTime(caminhoFinal)}");

        Console.WriteLine();

        string[] linhas = File.ReadAllLines(caminhoFinal);
        foreach (string linha in linhas)
            Console.WriteLine(linha);
        
        var caminhoCopia = Path.Combine(pasta, "arquivo1_copia.txt");

        File.Copy(caminhoFinal, caminhoCopia, true);

        File.Move(caminhoCopia, Path.Combine(pasta, "Copia", "arquivo1_copia.txt"), true);

        File.Copy(caminhoFinal, Path.Combine(pasta, "arquivo1_copia2.txt"), true);

        File.Delete(Path.Combine(pasta, "arquivo1_copia2.txt"));

    }

    static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
        return caminho;
    }
}

