namespace Exercicio_4;
public class Pessoa{
    public string? Nome { get; set; }
    public Pessoa(string? Nome){
        this.Nome = Nome;
    }

    public override string ToString(){
        return "Olá, meu nome é " + this.Nome + "\n";
    }
}
