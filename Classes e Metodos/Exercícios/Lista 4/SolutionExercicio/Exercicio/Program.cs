/*
r - Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int
como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai
retornar a nova velocidade como um double.
(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)

s - Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o
comportamento do parâmetro out.

*/


Carro c1 = new("Civic", "Honda", "Honda", 2020, 173);

Console.WriteLine($"Pontência do {c1.marca} {c1.modelo}: {c1.potencia}\n");

Console.WriteLine("Aumento da potência passando potencia e velocidade\n");

c1.aumentarPotenciaVelocidade(10, out double velocidade);

Console.WriteLine($"Nova potência: {c1.potencia} - Nova Velocidade: {velocidade}");

Console.WriteLine();

// Classe Carro

public class Carro
{

    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro()
    {

    }

    public Carro(string modelo, string montadora)
    {
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

    public int aumentarPotencia(int potencia)
    {
        return this.potencia += potencia += 3;
    }

    public int aumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return this.potencia += potencia;
    }

    public int aumentarPotenciaVelocidade(int potencia, out double velocidade){

        this.potencia += potencia += 7;
        velocidade = this.potencia * 1.75;
        return this.potencia;

    }

    /*A palavra return é usada para retornar um valor de um método. Quando o método é chamado, o valor é retornado e a execução do método é interrompida.*/

}