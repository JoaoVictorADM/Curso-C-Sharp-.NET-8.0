string entrada = null; // Variável para armazenar a entrada do usuário
try
{
    Console.Write("Informe um valor: ");
    entrada = Console.ReadLine(); // Lê a entrada do usuário
    if (entrada == null)
    {
        throw new ArgumentNullException("entrada", "A entrada não pode ser nula.");
    }
    else if (string.IsNullOrWhiteSpace(entrada))
    {
        throw new ArgumentException("A entrada não pode estar vazia.", "entrada");
    }
    else
    {
        Console.WriteLine("Entrada: " + entrada); // Exibe a entrada
    }
}
catch (ArgumentNullException ex)
{
    Tratamento de erros
 Console.WriteLine("Erro: " + ex.Message);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
finally
{
    // O bloco finally será executado independentemente de ter ocorrido uma exceção ou não
    Console.WriteLine("Fim do programa.");
}
