Console.WriteLine("Atráves de \"Linguagem\"\n");

List<string> nomes = new(){
    "Victor", "João", "Pedro", "Maria", "Ana", "Lucas", "Fernanda"
};

var resultado = from nome in nomes
                where nome.Contains('o')
                select nome;

ExibirNomes(resultado);

Console.WriteLine();

var resultado1 = from nome in nomes
                where nome.Contains('o')
                orderby nome
                select nome;

ExibirNomes(resultado1);

Console.WriteLine("\nAtráves de Métodos\n");

var resultado2 = nomes.Where(nome => nome.Contains('o'));

ExibirNomes(resultado2);
Console.WriteLine();

var resultado3 = nomes.Where(nome => nome.Contains('o')).OrderBy(nome => nome);

ExibirNomes(resultado3);

static void ExibirNomes(IEnumerable<string> nomes){
    foreach (var nome in nomes){
        Console.WriteLine(nome);
    }
}