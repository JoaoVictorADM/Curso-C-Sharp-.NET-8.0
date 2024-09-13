Dictionary<int, Aluno> resultados = new Dictionary<int, Aluno>();

int numAlunos = 2;

for(int i = 0; i < numAlunos; i++){

    Console.Write("Nome do aluno: ");
    string? nome = Console.ReadLine();

    Console.Write("Nota do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine();

    resultados.Add(i, new Aluno(nome, nota));

}

foreach(var item in resultados)
    Console.WriteLine($"{item.Key}: Aluno {item.Value.Nome} - Nota = {item.Value.Nota}");
Console.WriteLine();

Console.Write("Insira o id do aluno que deseja alterar a nota: ");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(resultados.ContainsKey(id)){
    Console.WriteLine($"Aluno {resultados[id].Nome} - Nota = {resultados[id].Nota}");
    Console.Write("Insira a nova nota do aluno: ");
    double novaNota = Convert.ToDouble(Console.ReadLine());

    resultados[id].Nota = novaNota;
    Console.WriteLine();

} else
    Console.WriteLine("Aluno não encontrado");

foreach (var item in resultados)
    Console.WriteLine($"{item.Key}: Aluno {item.Value.Nome} - Nota = {item.Value.Nota}");

Console.Write("Insira o id do aluno que deseja remover: ");
id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (resultados.ContainsKey(id)){
    Console.WriteLine($"Aluno {resultados[id].Nome} - Nota = {resultados[id].Nota} Removido");

    resultados.Remove(id);

} else
    Console.WriteLine("Aluno não encontrado");

foreach (var item in resultados)
    Console.WriteLine($"{item.Key}: Aluno {item.Value.Nome} - Nota = {item.Value.Nota}");

if(resultados.TryAdd(10, new Aluno("Vilma", 7)))
    Console.WriteLine("Aluna Vilma adicionada");
else
    Console.WriteLine("Aluna não adicionada");

var resultadosOrdenadosNome = resultados.OrderBy(x => x.Value.Nome);

foreach (var item in resultadosOrdenadosNome)
    Console.WriteLine($"{item.Key}: Aluno {item.Value.Nome} - Nota = {item.Value.Nota}");

resultados.Clear();

public class Aluno{

    public string? Nome;
    public double Nota;

    public Aluno(string? Nome, double Nota){
        this.Nome = Nome;
        this.Nota = Nota;
    }

}