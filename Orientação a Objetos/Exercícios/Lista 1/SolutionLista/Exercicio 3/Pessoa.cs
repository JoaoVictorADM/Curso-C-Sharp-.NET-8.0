namespace Exercicio_3;
public class Pessoa{

    protected string? Nome { get; set; }
    public Pessoa(string? Nome){
        this.Nome = Nome;
    }

    public override string ToString(){
        return "Olá, meu nome é " + this.Nome + "\n";
    }

}
