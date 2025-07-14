using ConsultasLINQ3;

var produtos = Produto.GetProdutos();

var produtosPorCategoria = produtos
                          .GroupBy(p => p.Categoria)
                          .OrderBy(grupo => grupo.Key)
                          .Select(c => new
                          {
                              Categoria = c.Key,
                              Produtos = c.OrderBy(p => p.Nome)
                          });

foreach(var grupo in produtosPorCategoria){
    Console.WriteLine($"Categoria: {grupo.Categoria}");

    foreach(var produto in grupo.Produtos){
        Console.WriteLine($"\tNome: {produto.Nome} - Preço: ${produto.Preco} - Estoque: {produto.Estoque}");
    }

}    
