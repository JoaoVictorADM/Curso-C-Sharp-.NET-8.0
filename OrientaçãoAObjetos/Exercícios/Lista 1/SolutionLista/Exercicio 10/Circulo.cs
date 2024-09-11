namespace Exercicio_10;

public class Circulo : Forma{
    public double Raio { get; set; }
    public Circulo(double Raio){
        this.Raio = Raio;
    }

    public override double Area(){
        return Math.PI * this.Raio * this.Raio;
    }

}
