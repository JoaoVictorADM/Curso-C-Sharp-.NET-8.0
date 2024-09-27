using System.Collections.ObjectModel;

var planetas = new List<string>() { "Mercúrio", "Vênus", "Terra", "Marte" };

var listaPlanetas = new ReadOnlyCollection<string>(planetas);

var novaLista = planetas.AsReadOnly();
ExibirLista(listaPlanetas);

Console.Write("\nJúpiter esta na coleção ? ");
Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta de índice 3 : {listaPlanetas[3]}");

Console.WriteLine($"\nIndice do planeta Terra : {listaPlanetas.IndexOf("Terra")}");

Console.WriteLine($"\nIndice do planeta dada : {listaPlanetas.IndexOf("dada")}");

Console.WriteLine("\nInserindo um novo elemento na Lista original (índice 4)\n");

planetas.Insert(4, "Plutão");

ExibirLista(listaPlanetas);

Console.WriteLine("\n\nCopiandos os elementos da coleção para um Array unidimensional");
string[] planetasArray = new string[listaPlanetas.Count + 2];
listaPlanetas.CopyTo(planetasArray, 1);
Console.WriteLine($"\nO Array copiado possui {planetasArray.Length} elementos");

ExibirLista(planetasArray);


static void ExibirLista<T>(IEnumerable<T> listaPlanetas){
    foreach (var planeta in listaPlanetas)
        Console.WriteLine($"\"{planeta}\"");
    Console.WriteLine();
}