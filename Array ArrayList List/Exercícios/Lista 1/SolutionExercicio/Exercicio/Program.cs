/*
 
1 - Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
    as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora

a - Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
 
b - Exiba os nomes da segunda e da penúltima fruta no console

c - Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas

d - Ordene a coleção de frutas na ordem ascendente

e - Exiba no console a coleção de nomes de frutas na ordem inversa

*/

string[] frutas = {"Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

ExibirFrutas(frutas);
Console.WriteLine($"Número de Elementos Array: {frutas.Length}\n");

foreach(string fruta in frutas)
    Console.Write($"{fruta} ");
Console.WriteLine($"Número de Elementos Array: {frutas.Length}\n");

Console.WriteLine(frutas[1]);
Console.WriteLine(frutas[frutas.Length - 2] + "\n");

frutas[2] = "Kiwi";
frutas[frutas.Length - 1] = "Caqui";
ExibirFrutas(frutas);

frutas = frutas.OrderBy(f => f).ToArray();

ExibirFrutas(frutas);

ExibirFrutas(frutas.Reverse().ToArray());

ExibirFrutas(frutas);

static void ExibirFrutas(string[] frutas){
    for (int i = 0; i < frutas.Length; i++)
        Console.Write($"{frutas[i]} ");
    Console.WriteLine("\n");
}