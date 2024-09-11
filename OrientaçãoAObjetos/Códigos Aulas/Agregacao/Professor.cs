namespace Agregacao;

public class Professor{
    public string? Nome { get; set; }
    public string? Disciplina { get; set; }
    public Professor(string? Nome, string? Disciplina){
        this.Nome = Nome;
        this.Disciplina = Disciplina;
    }
}
