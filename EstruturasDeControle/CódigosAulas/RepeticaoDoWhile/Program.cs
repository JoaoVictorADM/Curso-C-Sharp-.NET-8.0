Console.WriteLine("## Instrução Do While ##\n");

int i = 1;

do{
    Console.WriteLine($"i = {i++}");
}while (i <= 10);
Console.WriteLine();

i = 11;
do{
    Console.WriteLine($"i = {i++}");
}while (i <= 10);
Console.WriteLine();

int x = 0;

do{
    int y = 0;
    do{
        Console.Write($"[{x}][{y++}] ");
    }while(y < 5);
    x++;
    Console.WriteLine();
}while(x < 5);
