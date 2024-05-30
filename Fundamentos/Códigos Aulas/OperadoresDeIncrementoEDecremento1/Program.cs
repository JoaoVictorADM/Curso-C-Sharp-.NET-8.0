Console.WriteLine("## Operadores de Incremento e Decremento ##\n");

Console.WriteLine("Incremento");

int x = 10;
Console.WriteLine(x++);
Console.WriteLine(x);
Console.WriteLine();

x = 10;
Console.WriteLine(++x);
Console.WriteLine(x);
Console.WriteLine();

Console.WriteLine("Decremento");

x = 10;
Console.WriteLine(x--);
Console.WriteLine(x);
Console.WriteLine();

x = 10;
Console.WriteLine(--x);
Console.WriteLine(x);
Console.WriteLine();

Console.WriteLine("Contas envolvendo Incremento e Decremento");

x = 10;
int resultado = x++ + 10;
Console.WriteLine(resultado);

x = 10;
resultado = ++x + 10;
Console.WriteLine(resultado);
