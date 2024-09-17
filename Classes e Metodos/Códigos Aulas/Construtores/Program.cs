Console.WriteLine("## Construtores ##\n");

Aluno a1 = new();
Aluno a2 = new("Maria");
Aluno a3 = new("José", 21, "M", "S");

a1.emitirInfos();
a2.emitirInfos();
a3.emitirInfos();

public class Aluno {

    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovado;

    public Aluno(){

    }

    public Aluno(string? nome): this(nome, 1, null, null){

    }

    public Aluno(string? nome, int idade, string? sexo, string? aprovado)
    {
        this.idade = idade;
        this.sexo = sexo;
        this.aprovado = aprovado;
    }

    public void emitirInfos(){
        Console.WriteLine($"Nome: {nome}\nIdade: {idade}\nSexo: {sexo}\nAprovado: {aprovado}\n");
    }

}
