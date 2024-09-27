int[] numeros = new int[] { 109, 211, 313, 405, 519, 617, 711, 891, 951, 1001 };
Console.WriteLine("Números no array:");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"[{i}] - {numeros[i]}");
}
try
{
    Console.Write("Informe um índice para obter o valor correspondente: ");
    int indice = int.Parse(Console.ReadLine());
    int valor = numeros[indice];
    Console.WriteLine($"O valor no índice {indice} é: {valor}");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Erro: O índice está fora do intervalo válido.");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Erro: A entrada não pode ser nula.");
}
finally
{
    Console.WriteLine("Fim do programa.");
}
