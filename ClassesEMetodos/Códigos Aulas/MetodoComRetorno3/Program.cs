Console.WriteLine("## Métodos ##\n");

Cadastro ca = new();

var cl1 = ca.Registrar();
ca.exibirDados(cl1);

// alterar renda

ca.Registrar(cl1);
ca.exibirDados(cl1, "Renda Alterada");

public class Cliente{

    public string? nome;
    public int idade;
    public decimal renda;

    public Cliente()
    {
            
    }

    public Cliente(string? nome, int idade, decimal renda)
    {
        this.nome = nome;
        this.idade = idade;
        this.renda = renda;
    }


}

public class Cadastro{

    public Cliente Registrar(){
        Cliente c = new("Maria", 23, 3000);
        return c;
    }

    public Cliente Registrar(Cliente c){
        c.renda = 3500m;
        return c;
    }

    public void exibirDados(Cliente c){
        Console.WriteLine($"{c.nome} {c.idade} {c.renda.ToString("c")}");
    }

    public void exibirDados(Cliente c, string texto){
        Console.Write($"\n{texto}\t");
        Console.Write($"{c.nome} {c.renda.ToString("c")}");
    }

}