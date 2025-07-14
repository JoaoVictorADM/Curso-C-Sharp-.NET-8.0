using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

public class Program{

    static public string pastaRaiz;

    static Program(){
        pastaRaiz = Path.GetDirectoryName(GetCaminhoDoCodigoFonte()) ?? "d:";
    }

    public static void Main(string[] args){
        

        while(true){

            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Criar Arquivo");
            Console.WriteLine("2 - Gravar em Arquivo");
            Console.WriteLine("3 - Ler Arquivo");
            Console.WriteLine("4 - Procurar texto em arquivo");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine() ?? "0";

            Console.WriteLine();

            if (opcao == "0"){
                Console.WriteLine("Saindo");
                break;
            }

            HandleOpcoes(opcao);
        }
    }

    private static void HandleOpcoes(string opcao){

        if(opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4"){
            Console.WriteLine("Opção inválida, tente novamente.\n");
            return;
        }

        string nomeArquivo;

        Console.Write("Digite o nome do arquivo (com extensão): ");
        nomeArquivo = Console.ReadLine();

        Console.WriteLine();

        try{
            switch (opcao)
            {
                case "1":
                    CriarArquivo(nomeArquivo);
                    break;
                case "2":
                    GravarEmArquivo(nomeArquivo);
                    break;
                case "3":
                    LerArquivo(nomeArquivo);
                    break;
                case "4":
                    ProcurarTextoEmArquivo(nomeArquivo);
                    break;
            }
        } catch(Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
        }

    }
    private static void CriarArquivo(string nomeArquivo){

        string caminhoArquivo = Path.Combine(pastaRaiz, nomeArquivo);
        
        bool arquivoExiste = File.Exists(caminhoArquivo);

        if(arquivoExiste){

            string resposta;
            bool entradaValida;

            do{
                Console.WriteLine("O arquivo já existe, deseja sobreescrever?");
                Console.Write("Resposta(y/n): ");

                resposta = (Console.ReadLine().ToLower()) ?? "n";

                Console.WriteLine();

                entradaValida = resposta == "y" || resposta == "n";

                if(!entradaValida)
                    Console.WriteLine("Entrada inválida, digite 'y' para sim ou 'n' para não.\n");

            } while(!entradaValida);

            if(resposta == "n"){
                Console.WriteLine("Operação cancelada.\n");
                return;
            }

        }

        using FileStream fs = new FileStream(caminhoArquivo, FileMode.Create);

        if(arquivoExiste)
            Console.WriteLine($"Sobreescrendo Arquivo {nomeArquivo}");
        else
            Console.WriteLine($"Criando Arquivo {nomeArquivo}");

        Console.WriteLine();

    }

    private static void GravarEmArquivo(string nomeArquivo){

        string caminhoArquivo = Path.Combine(pastaRaiz, nomeArquivo);

        if(!File.Exists(caminhoArquivo)){
            Console.WriteLine($"Arquivo \"{nomeArquivo}\" não existe.\n");
            return;
        }

        Console.WriteLine("caminho arquivo" + caminhoArquivo);

        using StreamWriter writer = new StreamWriter(caminhoArquivo, true);

        Console.WriteLine("Digite o texto a ser gravado no arquivo (ou \"sAiR\" para finalizar):");

        while(true){
            Console.Write("Texto: ");

            string? texto = Console.ReadLine();

            Console.WriteLine();

            if (texto == "sAiR")
                break;
            
            writer.WriteLine(texto);
            writer.Flush();
        }

    }

    private static void LerArquivo(string nomeArquivo){

        string caminhoArquivo = Path.Combine(pastaRaiz, nomeArquivo);

        if(!File.Exists(caminhoArquivo)){
            Console.WriteLine($"Arquivo \"{nomeArquivo}\" não existe.\n");
            return;
        }

        using StreamReader reader = new StreamReader(caminhoArquivo);

        Console.WriteLine($"Lendo arquivo: {nomeArquivo}");

        string linha;

        while((linha = reader.ReadLine()) != null){
            Console.WriteLine(linha);
        }

        Console.WriteLine();

    }

    private static void ProcurarTextoEmArquivo(string nomeArquivo){
        string caminhoArquivo = Path.Combine(pastaRaiz, nomeArquivo);

        if(!File.Exists(caminhoArquivo)){
            Console.WriteLine($"Arquivo \"{nomeArquivo}\" não existe.\n");
            return;
        }

        Console.Write("Digite o texto a ser procurado no arquivo:");

        string textoProcurado = Console.ReadLine();

        Console.WriteLine();

        string linha;

        using StreamReader reader = new StreamReader(caminhoArquivo);

        while((linha = reader.ReadLine()) != null){
            if(linha.Contains(textoProcurado)){
                Console.WriteLine($"Texto encontrado na linha: {linha}");
                return;
            }
        }

        Console.WriteLine("Texto não encontrado.\n");
    }

    private static string GetCaminhoDoCodigoFonte([CallerFilePath] string caminho = ""){
        return caminho;
    }

}