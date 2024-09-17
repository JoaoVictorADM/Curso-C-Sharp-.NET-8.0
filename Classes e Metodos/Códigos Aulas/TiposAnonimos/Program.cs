var aluno = new{
    nome = "Maria",
    idade = 42
};

Console.WriteLine(aluno.nome + " - " + aluno.idade + " anos");

Console.ReadKey();

var aluno1 = new{
    id = 1,
    nome = "Jairo",
    email = "jairo@email.com",
    endereco = new { Id = 1, cidade = "Santos", pais = "Brasil" }
};

Console.WriteLine($"Nome: {aluno1.nome}");
Console.WriteLine($"Endereço:  {aluno1.endereco.cidade}");

Console.ReadKey();

var alunos = new[] {
             new { id = 1, nome = "Maria", email = "maria@email.com" },
             new { id = 2, nome = "Sonia", email = "sonia@email.com" },
             new { id = 3, nome = "Bruno", email = "bruno@email.com" }
           };

Console.WriteLine(alunos[0].nome);
Console.WriteLine(alunos[0].email);

Console.ReadKey();
