Console.WriteLine("## Operador Uniário e Ternário ##\n");

int x = 1;

int resultado = +x;
Console.WriteLine(resultado);

x = -1;

resultado = +x;
Console.WriteLine(resultado);

int y = 1;

Console.WriteLine();

resultado = -y;
Console.WriteLine(resultado);

y = -1;

resultado = -y;
Console.WriteLine(resultado);

Console.WriteLine();

Console.Write("Informe o numero: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {z} é {-z}");

Console.WriteLine("\n----------Operador Ternário----------\n");

Console.Write("Informe a temperatura: ");
float temperatura = Convert.ToInt32(Console.ReadLine());
string resultado1 = temperatura > 27 ? "Quente" : "Normal";

Console.WriteLine($"O dia está {resultado1}");
Console.WriteLine();

x = 20;
y = 10;

Console.WriteLine(x > y ? "x é maior que y" : y > x ? "y é maior que x" : "x é igual a y");

x = 10;
y = 20;

Console.WriteLine(x > y ? "x é maior que y" : y > x ? "y é maior que x" : "x é igual a y");

x = 20;
y = 20;

Console.WriteLine(x > y ? "x é maior que y" : y > x ? "y é maior que x" : "x é igual a y");