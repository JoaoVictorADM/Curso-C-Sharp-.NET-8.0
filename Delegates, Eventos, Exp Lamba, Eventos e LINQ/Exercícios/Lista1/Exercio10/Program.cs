/*
Exercício 1: Utilizando o método Where
Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para obter somente as
strings que contenham a letra 'a'.

 Exercício 2: Utilizando o método OrderBy
Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para ordenar os valores
em ordem crescente.

Exercício 3: Utilizando o método GroupBy
Dado um array de strings, escreva um programa em C# que use a biblioteca LINQ para agrupar as strings por
tamanho

Exercício 4: Utilizando o método FirstOrDefault
Dado um array de inteiros, escreva um programa em C# que use a biblioteca LINQ para obter o primeiro
número par do array.
*/

string[] strings = { "banana", "maçã", "laranja", "uva", "abacaxi" };

var exercicio1 = strings.Where((s) => s.Contains("a"));

Console.WriteLine("Item 1: ");
PrintArray(exercicio1);

int[] numeros = { 5, 3, 8, 1, 4 };

var exercicio2 = numeros.OrderBy(n => n);

Console.WriteLine("Item 2: ");
PrintArray(exercicio2);

string[] palavras = { "cachorro", "gato", "elefante", "rato", "tigre"};

var exercicio3 = palavras.GroupBy(p => p.Length);

Action<string> printString = (s) => Console.WriteLine("\t" + s);

foreach (var grupo in exercicio3){
    Console.WriteLine($"Palavras com {grupo.Key} letras:");
    grupo.ToList().ForEach(printString);
}
Console.WriteLine();

int[] numeros2 = { 7, 3, 9, 4, 6 };

var exercicio4 = numeros2.FirstOrDefault(n => n % 2 == 0);

Console.WriteLine($"Primeiro número par do array: {exercicio4}");

static void PrintArray<T>(IEnumerable<T> collection){
    foreach(var item in collection){
        Console.WriteLine("\t" + item);
    }
    Console.WriteLine();
}