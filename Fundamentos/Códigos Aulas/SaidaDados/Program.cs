
Console.WriteLine("Saída de dados : Formatação");

int idade = 25;
string nome = "Maria";
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine();

Console.Write(nome);
Console.Write(idade);
Console.WriteLine("\n");

//
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos");
Console.WriteLine("\n");

// Concatenação
Console.WriteLine("--------Concatenação--------");
Console.WriteLine(nome + " tem " + idade + " anos\n");

// Interpolação
Console.WriteLine("--------Interpolação--------");
Console.WriteLine($"{nome} tem {idade} anos\n");

// placeholders
Console.WriteLine("--------Placeholders--------");

Console.WriteLine("{0} tem {1} anos\n", nome, idade);