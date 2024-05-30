Console.WriteLine("## Operadores aritméticos ##\n");

Console.Write("Insira Numero 1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira Numero 1: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Soma de x+y = {x+y}");
Console.WriteLine($"Subtração de x-y = {x-y}");
Console.WriteLine($"Multiplicação de x*y = {x*y}");
Console.WriteLine($"Divisão de x/y = {x/(float)y}");
Console.WriteLine($"Módulo de x%y = {x%y}\n");

// Algumas operações usando a classe Math

Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x^y = {Math.Pow(x, y)}");
Console.WriteLine($"Minimo de x e y = {Math.Min(x, y)}");
Console.WriteLine($"Máximo de x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno de x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");


