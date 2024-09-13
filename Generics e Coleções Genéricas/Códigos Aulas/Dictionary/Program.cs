using System;
using System.Collections.Generic;

Dictionary<int, int> d = new Dictionary<int, int>();

d.Add(1, 1);
d.Add(3, 3);
d.Add(2, 2);
d.Add(4, 1);

var dic2 = new Dictionary<int, int>() {

    { 1, 1},
    { 3, 3},
    { 2, 2},
    { 4, 1}

};

try{
    d.Add(1, 1);
} catch (ArgumentException e){
    Console.WriteLine(e.Message);
}

Console.WriteLine(d.TryAdd(1, 1));


if(!d.ContainsKey(7)){
    d.Add(7, 7000);
    Console.WriteLine("\n-Incluindo o elemento com chave 7 e valor 7000");
    Console.WriteLine(d[7]);
}

Console.WriteLine("\n-Usando ContainsValue");

if(d.ContainsValue(7000))
    Console.WriteLine("O valor existe no Dicionário");
else
    Console.WriteLine("Não valor não existe no Dicionário");

if(d.ContainsKey(7)){
    Console.WriteLine("\n-Alterando o valor do elemento com chave 7");
    Console.WriteLine("Valor atual do item " + d[7]);
    d[7] = 7777;
    Console.WriteLine("Valor alterado do item " + d[7]);
}

Console.WriteLine("\n-Tentando obter elemento com chave(5) inexistente");

try{
    Console.WriteLine(d[5]);
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.ToString());
}

Console.WriteLine("\n-Usando TryGetValue() para a chave 5");

if(d.TryGetValue(5, out int valor))
    Console.WriteLine("Valor para a chave 5 = " + valor);
else
    Console.WriteLine("Chave não encontrada");

d.Add(6, 6666);
d.Add(8, 8888);

foreach(var item in d)
    Console.WriteLine($"{item.Key} {item.Value}");

SortedDictionary<int, int> sD = new SortedDictionary<int, int>(d);

Console.WriteLine("Dicionario ordenado");

foreach(var item in sD)
    Console.WriteLine($"{item.Key} {item.Value}");

Console.WriteLine("Ordenando pela LINQ");
var dOrdenado = d.OrderBy(x => x.Key);

foreach(var item in dOrdenado)
    Console.WriteLine($"{item.Key} {item.Value}");

