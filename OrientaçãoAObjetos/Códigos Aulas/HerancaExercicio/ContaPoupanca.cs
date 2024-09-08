namespace HerancaExercicio;

public class ContaPoupanca : ContaCorrente{

    private static decimal TaxaRendimento;

    static ContaPoupanca(){
        ContaPoupanca.TaxaRendimento = 0.005m;
    }

    public ContaPoupanca(string? Nome, int Numero) : base(Nome, Numero){
        
    }

    public override void Depositar(decimal valor){
        base.Depositar(valor);
        this.Saldo += valor * ContaPoupanca.TaxaRendimento;
    }

    public override void Sacar(decimal valor){

        if (valor <= 0){
            Console.WriteLine("Valor inválido\n");
            return;
        }

        if (valor > this.Saldo){
            Console.WriteLine("Saldo insuficiente\n");
            return;
        }

        this.Saldo -= valor;
    }

}
