namespace HerancaExercicio;

public class ContaCorrente{
    protected string? Nome { get; set; }
    protected int Numero { get; set; }
    protected decimal Saldo { get; set; }

    public ContaCorrente(string? Nome, int Numero){
        this.Nome = Nome;
        this.Numero = Numero;
        this.Saldo = 0.0m;
    }

    public virtual void Depositar(decimal valor){

        if(valor <= 0){
            Console.WriteLine("Valor inválido\n");
            return;
        }

        this.Saldo += valor;

    }

    public virtual void Sacar(decimal valor){

        if(valor <= 0){
            Console.WriteLine("Valor inválido\n");
            return;
        }

        this.Saldo -= valor;

    }

    public void ExibirSaldo() =>
        Console.WriteLine($"O saldo da conta {this.Numero} é de: {this.Saldo}\n");
    
}
