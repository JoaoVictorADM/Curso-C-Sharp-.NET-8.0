namespace Exercicio_3;
public class Professor : Pessoa{

    public Professor(string? Nome) : base(Nome){
        
    }

    public void Explicar(){
        Console.WriteLine($"O professor {this.Nome} está explicando\n");
    }

}
