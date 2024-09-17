namespace HerancaModificadorAcesso;

public class Conta{
    public int contador;
    public int Numero { get; set; }
    public decimal Saldo { get; set; }

    public decimal GetSaldo(){
        return this.Saldo;
    }
}
