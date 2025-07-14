using ConsultasLINQ1;

var produtos = Produto.GetProdutos();

Console.WriteLine("Produtos Eletrônicos: \n");
var produtosEletronicos = produtos
                         .Where(produto => produto.Categoria.Equals("Eletrônicos"));

ExibirProdutos(produtosEletronicos);

Console.WriteLine("Produtos com Valor >= 100 e estoque > 5: \n");
var produtosCaros = produtos
                   .Where(produto => produto.Preco >= 1000.0 && produto.Estoque > 5);

ExibirProdutos(produtosCaros);

Console.WriteLine("Produtos com estoque <= 10 ordenados por nome: \n");
var produtosEstoqueBaixo = produtos
                          .Where(produto => produto.Estoque <= 10)
                          .OrderBy(produto => produto.Nome);

ExibirProdutos(produtosEstoqueBaixo);

Console.WriteLine("Produtos com estoque <= 10 ordenados por nome: \n");
var produtosOrdenadosPorCategoriaENome = produtos
                                        .OrderBy(produto => produto.Categoria)
                                        .ThenBy(produto => produto.Nome);

string? categoriaAnterior = "";
foreach(var produto in produtosOrdenadosPorCategoriaENome)
{
    if(produto.Categoria != categoriaAnterior){
        Console.WriteLine($"\nCategoria: {produto.Categoria}");
        categoriaAnterior = produto.Categoria;
    }

    Console.WriteLine($"\tProduto: {produto.Nome}, Preço: {produto.Preco:C}, Estoque: {produto.Estoque}");
}

Console.WriteLine();

// Criando uma lista com o nome dos produtos
Console.WriteLine("Criando uma lista com o nome dos produtos");
var nomesProdutos = produtos.Select(p => p.Nome).OrderBy(nome => nome).ToList();
foreach (var nome in nomesProdutos){
    Console.WriteLine(nome);
}

Console.WriteLine();

// Filtrando produtos com preço menor que 500 com aumento de 10% e ordenados pelo nome do produto
Console.WriteLine("Filtrando produtos com preço menor que 500 com aumento de 10% e ordenados pelo nome do produto");

var produtoComAumento = produtos
                       .Where(p => p.Preco < 500.0)
                       .OrderBy(p => p.Nome)
                       .Select(p => new 
                       {
                           NomeProduto = p.Nome.ToUpper(), 
                           PrecoComAumento = p.Preco * 1.10
                       });


foreach(var produto in produtoComAumento){
    Console.WriteLine($"Produto: {produto.NomeProduto}, Preço com aumento: {produto.PrecoComAumento:C}");
}

Console.WriteLine();

// Realizando cálculos, somatório, média e contagem
Console.WriteLine("Realizando cálculos, somatório, média e contagem");
string categoria = "Eletrodomésticos";
double mediaPrecoEletrodomésticos = produtos.Where(p => p.Categoria.Equals(categoria))
                                       .Average(p => p.Preco);

Console.WriteLine($"Valor médio dos produtos eletrodomésticos: ${mediaPrecoEletrodomésticos}\n");

// Valor total do estoque de todos os produtos
Console.WriteLine("Valor total do estoque de todos os produtos");

double valorTotalEstoque = produtos.Where(p => p.Estoque > 0)
                                   .Sum(p => p.Preco * p.Estoque);

Console.WriteLine($"Valor total do estoque: ${valorTotalEstoque}\n");

// Número de produtos("Tipo de produto") com valor >= 1500

int quantidadeProdutosCaros = produtos.Where(p => p.Preco >= 1500.0).Count();

Console.WriteLine($"Quantidade de produtos(\"Tipo de produto\") com valor maior ou igual a $1500: {quantidadeProdutosCaros}");

static void ExibirProdutos(IEnumerable<Produto> produtosCaros){
    foreach (var produto in produtosCaros){
        Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco:C}, Estoque: {produto.Estoque}");
    }
    Console.WriteLine();
}