Console.WriteLine("## Structs ##\n");

Cliente cliente = new();
cliente.nome = "Maria";
cliente.idade = 19;

Console.WriteLine($"{cliente.nome} {cliente.idade}");

Console.ReadKey();

public struct Cliente
{
    public string? nome { get; set; }
    public int idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }
}