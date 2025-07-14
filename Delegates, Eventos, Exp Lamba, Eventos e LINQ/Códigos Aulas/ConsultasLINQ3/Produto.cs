namespace ConsultasLINQ3;

public class Produto{

    public int Id { get; set; }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public string? Categoria { get; set; }

    public static List<Produto> GetProdutos()
    {
        return new List<Produto>{
            new Produto { Id = 1, Nome = "Notebook", Preco = 2500.00, Estoque = 10, Categoria = "Eletrônicos" },
            new Produto { Id = 2, Nome = "Smartphone", Preco = 1500.00, Estoque = 20, Categoria = "Eletrônicos" },
            new Produto { Id = 3, Nome = "Camiseta", Preco = 50.00, Estoque = 100, Categoria = "Vestuário" },
            new Produto { Id = 4, Nome = "Calça Jeans", Preco = 120.00, Estoque = 50, Categoria = "Vestuário" },
            new Produto { Id = 5, Nome = "Tênis", Preco = 300.00, Estoque = 30, Categoria = "Vestuário" },
            new Produto { Id = 6, Nome = "Geladeira", Preco = 2000.00, Estoque = 5, Categoria = "Eletrodomésticos" },
            new Produto { Id = 7, Nome = "Micro-ondas", Preco = 800.00, Estoque = 15, Categoria = "Eletrodomésticos" },
            new Produto { Id = 8, Nome = "Liquidificador", Preco = 200.00, Estoque = 25, Categoria = "Eletrodomésticos" },
            new Produto { Id = 9, Nome = "Fritadeira Elétrica", Preco = 400.00, Estoque = 10, Categoria = "Eletrodomésticos" },
            new Produto { Id = 10, Nome = "Ar Condicionado", Preco = 3000.00, Estoque = 8, Categoria = "Eletrodomésticos" },
            new Produto { Id = 11, Nome = "Tênis", Preco = 100.00, Estoque = 10, Categoria = "Vestuário" },
        };
    }

}
