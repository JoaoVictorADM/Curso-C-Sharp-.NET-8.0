namespace HerancaExercicio;

public class ContaInvestimento : ContaCorrente{

    private static decimal Taxa;
    private static decimal Imposto;

    static ContaInvestimento(){
        ContaInvestimento.Taxa = 0.009m;
        ContaInvestimento.Imposto = 0.001m;
    }

    public ContaInvestimento(string? Nome, int Numero) : base(Nome, Numero){

    }

    public override void Depositar(decimal valor){
        base.Depositar(valor);
        this.Saldo += valor * ContaInvestimento.Taxa;
    }

    public override void Sacar(decimal valor){

        if(valor <= 0){
            Console.WriteLine("Valor inválido\n");
            return;
        }

        decimal valorComImposto = valor * (1 + ContaInvestimento.Imposto);

        if(valorComImposto > this.Saldo){
            Console.WriteLine($"Saldo insuficiente - Saldo: {this.Saldo} - Valor do saque mais impostos: {valorComImposto}\n");
            return;
        }

        this.Saldo -= valorComImposto;
    }

}
