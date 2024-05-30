Console.WriteLine("## Estrutura de repetição com goto/label ##\n");

int i = 1;

repetir:

Console.WriteLine($"i = {i++}");

if (i <= 9)
    goto repetir;
