Console.WriteLine("## Construtor estático ##\n");

//invoca o construtor parametrizado e o estatico
Pessoa p1 = new(19, "Maria");

Console.WriteLine(p1.nome + " - " + p1.idade);
Console.WriteLine("Idade Minima " + Pessoa.idadeMinima);

//invoca somente o construtor parametrizado
Pessoa p2 = new Pessoa(20, "Manoel");

Console.WriteLine(p2.nome + " - " + p2.idade);
Console.WriteLine("Idade Minima " + Pessoa.idadeMinima);

Console.ReadKey();