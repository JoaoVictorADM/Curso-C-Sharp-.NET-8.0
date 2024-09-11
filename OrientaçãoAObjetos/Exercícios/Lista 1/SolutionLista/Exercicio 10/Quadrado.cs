namespace Exercicio_10;

public class Quadrado : Forma{
    public double Lado { get; set; }

    public Quadrado(double Lado){
        this.Lado = Lado;
    }

    public override double Area(){
        return this.Lado * this.Lado;
    }

}
