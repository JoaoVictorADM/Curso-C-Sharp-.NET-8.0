Console.WriteLine("## Precedência de Operadores ##\n");

int x = 10 - 2 * 3;
Console.WriteLine(x);

x = (10 - 2) * 3;
Console.WriteLine(x);

Console.WriteLine();

bool b1 = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(b1);

b1 = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(b1);

Console.WriteLine();

int a = 5, b = 6, c = 4;

int r = --a * b - ++c;
Console.WriteLine(r);

