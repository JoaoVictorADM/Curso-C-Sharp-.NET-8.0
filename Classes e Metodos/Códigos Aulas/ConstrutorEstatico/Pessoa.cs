public class Pessoa {

    public static int idadeMinima;

    public int idade { get; set; }
    public string nome { get; set; } = string.Empty;

    public Pessoa(){ 

    }

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        this.idade = idade;
        this.nome = nome;
    }

}



