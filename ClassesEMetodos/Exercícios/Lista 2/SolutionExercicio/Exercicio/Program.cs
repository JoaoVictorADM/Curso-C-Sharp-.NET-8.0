/*g - Crie um construtor que permita criar um carro somente usando os atributos : Modelo e Montadora (não
use a palavra-chave this)

h- Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro

i- Crie um método chamado VelocidadeMaxima que recebe um parâmetro do tipo int chamado potencia que
vai retornar um double representando a velocidade máxima do carro
( Para calcular a velocidade multiplique a potencia por 1.75)

j- Explique o comportamento da palavra return*/


// Classe Carro

public class Carro{

    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro(){

    }

    public Carro(string modelo, string montadora){
        this.modelo = modelo;
        this.montadora = montadora;
    }

    /*O construtor modelo e montadora é um construtor que permite criar um carro somente usando os atributos modelo e montadora, e os outros atributos recebem seus valores padrões de inicialização*/

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public void acelerar() =>
        System.Console.WriteLine("Acelerando...");

    public void acelerar(string? marca) =>
        System.Console.WriteLine($"Acelerando meu {marca}");

   public double velocidadeMaxima(int potencia) =>
        potencia * 1.75;

    /*A palavra return é usada para retornar um valor de um método. Quando o método é chamado, o valor é retornado e a execução do método é interrompida.*/

}