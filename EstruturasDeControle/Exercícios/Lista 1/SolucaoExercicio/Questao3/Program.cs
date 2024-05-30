int i = 1, soma = 0;

Console.WriteLine("Os primeiros números naturais são:");
while (i <= 10){
    Console.Write(i + " ");
    soma += i;
    i++;
}
Console.WriteLine($"\nA soma dos números é: {soma}");

i = 1; soma = 0;

Console.Write("\nOs primeiros números naturais são:");
do{
    Console.Write(i + " ");
    soma += i;
    i++;
}while (i <= 10);
Console.WriteLine($"\nA soma dos números é: {soma}");

i = 1; soma = 0;

Console.WriteLine("\nOs primeiros números naturais são:");
for( ; i <= 10; i++){
    Console.Write(i + " ");
    soma += i;
}
Console.WriteLine($"A soma dos números é: {soma}");