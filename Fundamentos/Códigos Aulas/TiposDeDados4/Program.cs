using System.Reflection.Metadata;
using System.Runtime.InteropServices.ObjectiveC;
using System.Runtime.Remoting;

internal class Program{
    private static void Main(string[] args){

        Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");
        Console.WriteLine();

        string frase = "Hello João!";

        Console.WriteLine(frase);

        for (int i = 0; i < frase.Length; i++)
        {
            Console.Write(frase[i] + " ");
        }

        Console.WriteLine("\n");

        //Objeto suporta todos os tipos de dados

        object nota = 10;
        object valorDolar = 5.03m;
        object luzAcesa = true;
        object nome = "João";

        Console.WriteLine(nota);
        Console.WriteLine(valorDolar);
        Console.WriteLine(luzAcesa);
        Console.WriteLine(nome);

        Console.WriteLine();

        dynamic nota1 = 10;
        dynamic valorDolar1 = 5.03m;
        dynamic luzAcesa1 = true;
        dynamic nome1 = "João";

        Console.WriteLine(nota1);
        Console.WriteLine(valorDolar1);
        Console.WriteLine(luzAcesa1);
        Console.WriteLine(nome1);
    }
}
