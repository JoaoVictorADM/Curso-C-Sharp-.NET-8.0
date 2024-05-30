Console.WriteLine("## Entrada de dados ##\n");

Console.Write("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine();

Console.Write("Informe sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Seu nome é {nome} e você tem {idade} anos");
