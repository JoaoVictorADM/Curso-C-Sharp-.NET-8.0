namespace Exercicio5;

public class Produto{

    public string? Nome { get; set; }
    public decimal Preco;

    public Produto(string Nome, decimal Preco){
        this.Nome = Nome;
        this.Preco = Preco;
    }

}
