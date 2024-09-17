/*
 
w - Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.

w1 - Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se
for informado maior que 2022 seja atribuído 2022 ao valor do ano.

w2 - Explicar a diferença entre campo e propriedade.

 */

Carro c1 = new("Civic", "Honda", "Honda", 2020, 173);

Console.WriteLine($"Ano: {c1.Ano}");
c1.Ano = 1999;

Console.WriteLine($"Ano: {c1.Ano}");
c1.Ano = 2023;

Console.WriteLine($"Ano: {c1.Ano}");
c1.Ano = 2018;

Console.WriteLine($"Ano: {c1.Ano}");


/*
 
 Um campo é uma variável de qualquer tipo que é declarada diretamente na classe
 Uma propriedade é um membro que fornece um mecanismo flexível para ler, gravar ou calcular o valor de um campo privado.
 
 
 */

public class Carro
{

    public string? modelo;
    public string? montadora;
    public string? marca;
    private int ano;
    public int potencia;
    public static double valorIPVA;

    public int Ano{

        get { return this.ano; }

        set{

            if(value < 2000)
                this.ano = 2000;
            else if(value > 2022)
                this.ano = 2022;
            else
                this.ano = value;


        }

    }

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

    public int aumentarPotenciaVelocidade(int potencia, out double velocidade)
    {

        this.potencia += potencia += 7;
        velocidade = this.potencia * 1.75;
        return this.potencia;

    }

    public void exibirInfo(string? modelo, string? montadora, string? marca, int potencia, int ano = 2021)
    {
        System.Console.WriteLine($"Modelo: {modelo}");
        System.Console.WriteLine($"Montadora: {montadora}");
        System.Console.WriteLine($"Marca: {marca}");
        System.Console.WriteLine($"Potência: {potencia}");
        System.Console.WriteLine($"Ano: {ano}\n");
    }

    /*A palavra return é usada para retornar um valor de um método. Quando o método é chamado, o valor é retornado e a execução do método é interrompida.*/

    public static void obterValorIPVA()
    {
        Carro.valorIPVA = 4.0;
    }

}