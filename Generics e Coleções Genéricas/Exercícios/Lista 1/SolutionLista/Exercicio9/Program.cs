string[] nomes = {"Daniel", "Gustavo", "Antônio", "Murilo", "Henrique",
                  "Paulo", "Mateus", "Felipe", "Pedro", "Vitor",
                  "Luiz", "João", "Renan", "Ezequiel", "Davi",
                  "Marlon", "Igor", "Lucas", "Nicolas", "Wesley",
                  "Pablo", "Vinícius", "André", "Marcelo", "Caio",
                  "Bruno", "Leonardo", "Rafael", "Cauê", "Diego",
                  "Douglas", "Giovane", "Guilherme", "Jean", "Jorge" };

List<Aluno> listaAlunos = new List<Aluno>();

for(int i = 0; i < 5; i++){

    Random random = new Random();

    string nome = nomes[random.Next(0, nomes.Length)];
    string sexo = "Masculino";
    int idade = random.Next(18, 50);

    listaAlunos.Add(new Aluno(nome, sexo, idade));

}

foreach(var aluno in listaAlunos){
    Console.WriteLine("Nome: " + aluno.Nome);
    Console.WriteLine("Sexo: " + aluno.Sexo);
    Console.WriteLine("Idade: " + aluno.Idade);
    Console.WriteLine("-------------------------------------------------");
}

public class Aluno{

    public string? Nome { get; set; }
    public string? Sexo { get; set; }
    public int Idade { get; set; }

    public Aluno(string? Nome, string? Sexo, int Idade){
       this.Nome = Nome;
       this.Sexo = Sexo;
       this.Idade = Idade;
    }

}