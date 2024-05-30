Console.WriteLine("## Instrução IF ##\n");

Console.Write("Cliente Especial (true/false): ");
var resposta = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine();

if(resposta)
    Console.WriteLine("Desconto de 10%\n");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(x == y)
    Console.WriteLine("x igual a y");
if (x > y)
    Console.WriteLine("x maior que y");
if (x < y)
    Console.WriteLine("x menor que y");
    
