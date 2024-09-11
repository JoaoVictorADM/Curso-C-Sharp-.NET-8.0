namespace Exercicio_1;

public class Carro: IVeiculo{

    public int Gasolina { get; set; }

    public Carro(int Gasolina){
        this.Gasolina = Gasolina;
    }

    public void Dirigir(){
        Console.WriteLine($"{(this.Gasolina > 0 ? "Dirigindo o carro.." : "Sem gasolina...")}");
    }

    public bool Abastecer(int Gasolina){
        this.Gasolina += Gasolina;
        return true;
    }

}
