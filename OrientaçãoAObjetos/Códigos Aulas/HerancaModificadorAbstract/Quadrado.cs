namespace HerancaModificadorAbstract;
public class Quadrado : Forma{
    public double Lado { get; set; }
    public override void CalcularArea(){
        this.Area = this.Lado * this.Lado;
    }

    public override void CalcularPerimetro(){
        this.Perimetro = 4 * this.Lado;
    }
}

