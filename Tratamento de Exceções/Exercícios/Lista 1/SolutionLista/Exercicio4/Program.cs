using static System.Runtime.InteropServices.JavaScript.JSType;

int idade = 0;
string nome = null;
try
{
    Console.WriteLine("Informe a sua idade");
    idade = Convert.ToInt32(Console.ReadLine());
    if (idade < 0)
    {
        throw new ArgumentNullException("A idade não pode ser negativa.");
    }
    if (idade == 0)
    {
        Tratamento de erros
    throw new NotImplementedException("A idade ainda não foi definida.");
    }
    Console.WriteLine("Informe o seu nome");
    nome = Console.ReadLine();
    if (string.IsNullOrEmpty(nome))
    {
        throw new NullReferenceException("O nome não pode ser nulo nem vazio");
    }
    Console.WriteLine($"Nome: {nome}, Idade: {idade}");
}
catch (ArgumentException e)
{
    Console.WriteLine("Erro de argumento: " + e.Message);
}
catch (NotImplementedException e)
{
    Console.WriteLine("Erro de implementação: " + e.Message);
}
catch (NullReferenceException e)
{
    Console.WriteLine("Erro de referência nula: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Erro inesperado: " + e.Message);
}