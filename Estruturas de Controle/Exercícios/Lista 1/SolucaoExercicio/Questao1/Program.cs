int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nPrimeiro Número: {num1}\nSegundo Número: {num2}\nTerceiro Número: {num3}\n");

if(num1 > num2)
    if(num1 > num3)
        Console.WriteLine($"O primerio número: {num1} é o maior");
    else
        Console.WriteLine($"O terceiro número: {num3} é o maior");
else if(num2 > num3)
    Console.WriteLine($"O segundo número: {num2} é o maior");
else
    Console.WriteLine($"O terceiro número: {num3} é o maior");
    

