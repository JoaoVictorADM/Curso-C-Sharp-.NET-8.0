/*
 
5 - Dada uma classe Produto contendo duas propriedades : Nome (string) e Preco (decimal). Crie uma lista
de objetos do tipo Produto usando os seguinte dados:
Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55

A seguir realize as seguintes operações na lista de objetos Produto criada :

1 - Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média dopreço dos produtos e a quantidade 
de produtos na lista

2 - Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos

3 - Ordene a lista pelo nome do produto e exiba a lista ordenada

4 - Obtenha e exiba no console os produtos com preço inferior a R$ 5,00

5  Localize na lista o produto com nome Estojo
 
*/

using Exercicio5;

List<Produto> produtos = new(){
    new Produto("Clips", 3.95m),
    new Produto("Caneta", 5.99m),
    new Produto("Lápis", 4.15m),
    new Produto("Estojo", 6.99m),
    new Produto("Caderno", 7.55m)
};

ExibirInfosProdutos(produtos);

static void ExibirInfosProdutos(List<Produto> produtos){
    Console.WriteLine("Relação dos produtos: ");

    decimal soma = 0.0m;

    foreach(Produto produto in produtos){
        Console.WriteLine($"{produto.Nome} - {produto.Preco}");
        soma += produto.Preco;
    }

    Console.WriteLine($"\nSoma total dos produtos: {soma} - Média de preço: {soma / produtos.Count} - Quantidade de produtos: {produtos.Count}\n");
}

produtos.Add(new Produto("Mochila", 22.44m));

ExibirInfosProdutos(produtos);

produtos = produtos.OrderBy(p => p.Nome).ToList();

ExibirInfosProdutos(produtos);

List<Produto> produtosInferior5 = produtos.FindAll(produto => produto.Preco < 5.0m);

ExibirInfosProdutos(produtosInferior5);

int produtoEstojo = produtos.FindIndex(produto => produto.Nome == "Estojo");

if(produtoEstojo >= 0)
    Console.WriteLine($"Produto {produtos[produtoEstojo]} encontrado - Índice: {produtoEstojo}");