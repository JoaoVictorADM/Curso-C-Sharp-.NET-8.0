using ConsultasLINQ2;

var produtos = Produto.GetProdutos();

Console.WriteLine("First - Localiza o primeiro elemento");
var primeiroProduto = produtos.First();

Console.WriteLine($"Nome: {primeiroProduto.Nome} - Preço: ${primeiroProduto.Preco}\n");

try{
    Console.WriteLine("First - Localiza o primeiro elemento usando o critério de nome");
    
    var primeiraOcorrencia1 = produtos.First(p => p.Nome.Equals("Tênis"));

    Console.WriteLine($"Nome: {primeiraOcorrencia1.Nome} - Preço: ${primeiraOcorrencia1.Preco}\n");
} catch(Exception e){
    Console.WriteLine(e.Message);
}

Console.WriteLine("FirstOrDefault - Localiza o primeiro elemento usando o critério de nome");
var primeiraOcorrencia2 = produtos.FirstOrDefault(p => p.Nome.Equals("Tênis "));

if(primeiraOcorrencia2 != null)
    Console.WriteLine($"Nome: {primeiraOcorrencia2.Nome} - Preço: ${primeiraOcorrencia2.Preco}\n");
else
    Console.WriteLine("Nenhum produto encontrado com o nome especificado.\n");

Console.WriteLine("Last - Localiza o ultimo elemento");
var ultimoProduto = produtos.Last();

Console.WriteLine($"Nome: {ultimoProduto.Nome} - Preço: ${ultimoProduto.Preco}\n");

try
{
    Console.WriteLine("Last - Localiza o ultimo elemento usando o critério de nome");

    var primeiraOcorrencia1 = produtos.Last(p => p.Nome.Equals("Tênis"));

    Console.WriteLine($"Nome: {primeiraOcorrencia1.Nome} - Preço: ${primeiraOcorrencia1.Preco}\n");
} catch(Exception e){
    Console.WriteLine(e.Message);
}

Console.WriteLine("LastOrDefault - Localiza o ultimo elemento usando o critério de nome");
var primeiraOcorrencia3 = produtos.LastOrDefault(p => p.Nome.Equals("Tênis "));

if (primeiraOcorrencia2 != null)
    Console.WriteLine($"Nome: {primeiraOcorrencia2.Nome} - Preço: ${primeiraOcorrencia2.Preco}\n");
else
    Console.WriteLine("Nenhum produto encontrado com o nome especificado.\n");


// faça exemplos usando o método Single e SingleOrDefault


try{
    Console.WriteLine("Single - Localiza o único elemento usando o critério de nome");
    var produtoUnico = produtos.Single(p => p.Nome.Equals("Tênis"));
    Console.WriteLine($"Nome: {produtoUnico.Nome} - Preço: ${produtoUnico.Preco}\n");
} catch(Exception e){
    Console.WriteLine(e.Message);
}

Console.WriteLine();

try{
    Console.WriteLine("Single - Localiza o único elemento usando o critério de nome");
    var produtoUnico = produtos.Single(p => p.Nome.Equals("Notebook"));
    Console.WriteLine($"Nome: {produtoUnico.Nome} - Preço: ${produtoUnico.Preco}\n");
}
catch(Exception e){
    Console.WriteLine(e.Message);
}

Console.WriteLine("SingleOrDefault - Localiza o único elemento usando o critério de nome");
var produtoUnicoOuNulo = produtos.SingleOrDefault(p => p.Nome.Equals("Tênis "));
Console.WriteLine(
    produtoUnicoOuNulo != null 
    ? $"Nome: {produtoUnicoOuNulo.Nome} - Preço: ${produtoUnicoOuNulo.Preco}\n" 
    : "Nenhum produto encontrado com o nome especificado.\n"
);