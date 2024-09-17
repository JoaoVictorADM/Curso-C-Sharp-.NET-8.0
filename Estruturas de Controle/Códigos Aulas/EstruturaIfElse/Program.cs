Console.WriteLine("## Instrução If-Else ##\n");

Console.Write("Informe a nota do aluno: ");
int nota = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Aluno ");

if (nota >= 6)
    Console.WriteLine("aprovado\n");
else
    Console.WriteLine("reprovado\n");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (x == y)
    Console.WriteLine("x igual a y");
else
    if(x > y)
        Console.WriteLine("x maior que y");
    else
        Console.WriteLine("x menor que y");