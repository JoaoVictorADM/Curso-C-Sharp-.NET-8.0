Console.WriteLine("## Instrução While ##\n");

int i = 1;

while(i <= 9)
    Console.WriteLine($"i = {i++}");
Console.WriteLine();

int contador = 1;

Console.Write("Insira um número maior que zero: ");
int numero = Convert.ToInt32(Console.ReadLine());

if(numero <= 0)
    return;

while(contador <= 10)
    Console.WriteLine($"{numero}x{contador} = {contador++*numero}");
Console.WriteLine();

while(true){

    Console.Write("Insira um número maior que zero: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if(numero <= 0)
        break;

    if(numero % 2 == 0)
        Console.WriteLine("Número par");
    else
        Console.WriteLine("Número ímpar");

    Console.Write("Deseja continuar? (s/n): ");
    var resposta = Console.ReadLine();

    if (resposta == "n")
        break;
}

int x = 0, y = 0;

while(x <= 4){
    y = 0;
    while(y <= 4)
        Console.Write($"[{x}][{y++}] ");
    x++;
    Console.WriteLine();
}
    

