namespace Exercicio4;

public class Pessoa{

    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string Nome, int Idade){
        this. Nome = Nome;
        this.Idade = Idade;
    }

    public void Exibir() =>
        Console.WriteLine($"Nome: {Nome} - Idade: {Idade}\n");
    

}

