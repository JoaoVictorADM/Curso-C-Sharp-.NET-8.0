Console.Write("Insira o numero que deseja saber o fatorial: ");
int fatorial = 1, num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
    fatorial *= i;

Console.WriteLine($"\nO fatorial de {num} é {fatorial}");