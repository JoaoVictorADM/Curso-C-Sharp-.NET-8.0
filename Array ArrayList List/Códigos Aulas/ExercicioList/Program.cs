List<Aluno> alunos = new();

for (int i = 0; i < 3; i++)
{
    Console.Write("Digite o nome do aluno: ");
    string nome = Console.ReadLine();
    Console.Write("Digite a nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();
    alunos.Add(new Aluno(nome, nota));
}

ExibirAlunos(alunos);

alunos.Add(new Aluno("Bia", 7.75));
alunos.Add(new Aluno("Mario", 8.95));

ExibirAlunos(alunos);

Console.WriteLine("Localizando Aluna Amanda\n");
Aluno alunaAmanda = alunos.Find(aluno => aluno.Nome.Equals("Amanda"));

if(alunaAmanda != null)
    alunos.Remove(alunaAmanda);

ExibirAlunos(alunos);

alunos = alunos.OrderBy(aluno => aluno.Nome).ToList();

ExibirAlunos(alunos);

// Lista de alunos com nota maior ou igual a 8
List<Aluno> AlunosNotaMaior = alunos.Where(aluno => aluno.Nota >= 8).ToList();

ExibirAlunos(AlunosNotaMaior);

static void ExibirAlunos(List<Aluno> alunos)
{
    double somaNotas = 0.0;

    foreach (Aluno aluno in alunos)
    {
        Console.WriteLine($"Aluno {aluno.Nome} - Nota: {aluno.Nota}");
        somaNotas += aluno.Nota;
    }

    Console.WriteLine($"\nQuantidade de Alunos: {alunos.Count} - Média Aritmética das notas: {somaNotas / alunos.Count}\n");
}

public class Aluno
{
    public string? Nome { get; set; }
    public double Nota { get; set; }

    public Aluno(string? Nome, double Nota)
    {
        this.Nome = Nome;
        this.Nota = Nota;
    }

}

