/*
9- Crie um método de extensão para a classe List<int> na linguagem C# que, dado uma lista de inteiros,
retorne a soma de todos os elementos da lista que são ímpares.

Em seguida, crie um programa que instancie uma lista de inteiros com alguns números ímpares e alguns
números pares e use o método de extensão criado para obter a soma dos números ímpares da lista.
*/

using Exercicio9;

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine($"Soma dos numeros impares: {numeros.somaImpares()}");

