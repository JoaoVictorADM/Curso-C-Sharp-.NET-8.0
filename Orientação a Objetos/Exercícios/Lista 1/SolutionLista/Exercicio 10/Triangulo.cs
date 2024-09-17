namespace Exercicio_10;
public class Triangulo : Forma{
    public double Altura { get; set; }
    public double Base { get; set; }

    public Triangulo(double Altura, double Base){
        this.Altura = Altura; 
        this.Base = Base;
    }

    public override double Area(){
        return (this.Altura * this.Base) / 2.0;
    }

}
