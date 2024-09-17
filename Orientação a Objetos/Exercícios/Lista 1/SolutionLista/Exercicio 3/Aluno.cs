namespace Exercicio_3;
public class Aluno : Pessoa{
    public Aluno(string? Nome) : base(Nome){

    }

    public void Estudar(){
        Console.WriteLine($"O aluno {this.Nome} está estudando\n");
    }

}
