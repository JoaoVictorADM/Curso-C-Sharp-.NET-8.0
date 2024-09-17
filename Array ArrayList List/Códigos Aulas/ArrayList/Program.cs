using System.Collections;

ArrayList lista1;
lista1 = new ArrayList();

ArrayList lista2 = new ArrayList();

var lista3 = new ArrayList();

ArrayList lista4 = new();

ArrayList lista5 = new(5);

ArrayList lista6 = new() { 1, 2, 3, 4, 0 };

ArrayList lista7 = ["Maria", 5, true, " ", null];

lista7.Add(3.5);

lista7.Insert(2, "Paulo");

foreach (var item in lista7)
{
    Console.Write(item + " ");
}

Console.WriteLine("\n");

ArrayList lista8 = new() { 1, 2, 3, 4 };

lista8.AddRange(lista7);

foreach (var item in lista8)
{
    Console.Write(item + " ");
}

lista7.Insert(2, lista8);

Console.WriteLine("\n");

var lista = new ArrayList() { "Ana", 5, true, " ", null, 1.1, "Zé", 3, 9, 0 };

lista.Remove(null); // Remove a primeira aparição do objeto na lista

lista.RemoveAt(4); // Remove o elemento na posição 4

lista.RemoveRange(0, 2); // Remove 2 elementos a partir da posição 0

Console.WriteLine(lista.Contains("Zé")); // Verifica se o objeto está na lista

lista6.Sort(); // Preciso ter objetos do mesmo tipo, usa o quick sort

lista6.Clear(); // Remove todos os elementos da lista
