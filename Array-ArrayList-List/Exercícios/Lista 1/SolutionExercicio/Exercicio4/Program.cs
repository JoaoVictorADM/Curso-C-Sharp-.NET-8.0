/*
 
4 - Crie um programa C# que usa uma ArrayList para armazenar uma lista de objetos pessoas.

a - Primeiro crie uma classe chamada Pessoa.cs com duas propriedades (nome e idade) e um método Exibir() para imprimir o nome e a idade;

b - A seguir crie uma ArrayList e solicite a informação dos nomes e idades de 3 pessoas via teclado armazenando as informações na ArrayList.

c - A seguir exiba no console a lista das pessoas com nome e idade

d - Inclua mais dois objetos Pessoa na lista e exiba a nova lista de pessoas

e - Remova o último elemento da coleção e exiba a lista completa

Use seguintes dados iniciais: Ana, 22 - Diná, 21 - Maria, 19
Ao incluir os objetos pessoa use os dados : Jaime,20 - Tânia,18 

*/

using Exercicio4;
using System.Collections;

ArrayList pessoas = new();

for(int i = 0; i < 3; i++){

    Console.Write($"Insira o nome da {i + 1} pessoa: ");
    string? nome = Console.ReadLine();
    Console.Write($"Insira a idade da {i + 1} pessoa: ");
    int idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    pessoas.Add(new Pessoa(nome, idade));

}

for(int i = 0; i < pessoas.Count; i++)
    ((Pessoa)pessoas[i]).Exibir();
Console.WriteLine();

pessoas.Add(new Pessoa("Jaime", 20));
pessoas.Add(new Pessoa("Tânia", 18));

for(int i = 0; i < pessoas.Count; i++)
    ((Pessoa)pessoas[i]).Exibir();
Console.WriteLine();

pessoas.RemoveAt(pessoas.Count - 1);

for(int i = 0; i < pessoas.Count; i++)
    ((Pessoa)pessoas[i]).Exibir();
