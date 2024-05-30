Console.WriteLine("## Instrução For ##\n");

int resultado, numero;

Console.Write("Informe um número inteiro: ");
numero = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++){
    resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
Console.WriteLine();

for (double i = 1.01; i <= 10.10; i+=0.1)
    Console.WriteLine($"{numero} x {i} = {numero * i}");

for(int x = 0, y = 0; x+y < 20; x++, y++){
    Console.WriteLine($"x = {x} - y = {y}");
}
Console.WriteLine();

for (int x = 0; x < 5; x++){
    for(int y = 0; y < 5; y++){
        Console.Write($"[{x}][{y}] ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int b = 1;

for ( ; b <= 10; b++){
    Console.WriteLine($"b = {b}");
}

Console.WriteLine();