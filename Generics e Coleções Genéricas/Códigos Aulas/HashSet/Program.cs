var numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var frutas = new HashSet<string> { "maçã", "banana", "laranja", "pêra", "uva" };

HashSet<int> pares = new HashSet<int>();

for(int i = 0; i < 10; i++)
    pares.Add(i * 2);

// Construtor usando IEnumerable

var lista2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var numeros2 = new HashSet<int>(lista2);