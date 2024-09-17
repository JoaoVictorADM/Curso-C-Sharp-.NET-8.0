int[] numeros;

numeros = new int[10]{1, 2, 3, 4, 5 , 6, 7, 8, 10, 9};

string[] nomes = new string[3] {"João", "Maria", "José"};

string[] nomes1 = new string[] { "João", "Maria", "José" };

string[] nomes2 = { "João", "Maria", "José" };

Console.WriteLine("For\n");

for(int i = 0; i < numeros.Length; i++)
    Console.WriteLine($"Índice {i}: {numeros[i]}");

Console.WriteLine();

for(int i = 0; i < nomes2.Length; i++)
    Console.WriteLine($"Índice {i}: {nomes2[i]}");

Console.WriteLine();

Console.WriteLine("Foreach\n");

foreach(int numero in numeros)
    Console.WriteLine(numero);

Console.WriteLine();

foreach(string nome in nomes2)
    Console.WriteLine(nome);

Console.WriteLine();

// Métodos da Classe Array

Console.WriteLine("Métodos Classe Array\n");

Array.Sort(numeros);

foreach(int numero in numeros)
    Console.WriteLine(numero);

Console.WriteLine();

Array.Sort(nomes2);

foreach (string nome in nomes2)
    Console.WriteLine(nome);

Console.WriteLine();

Array.Reverse(numeros);

foreach (int numero in numeros)
    Console.WriteLine(numero);

Array.Reverse(numeros);

Console.WriteLine();

Console.WriteLine($"Índice valor 10: {Array.BinarySearch(numeros, 10)}\n");
Console.WriteLine($"Índice valor 12: {Array.BinarySearch(numeros, 12)}");
