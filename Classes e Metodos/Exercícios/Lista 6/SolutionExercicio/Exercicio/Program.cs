/*
 
 x - Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para
todos os carros

y - Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva

z - Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static.

 */

Carro c1 = new("Civic", "Honda", "Honda", 2020, 173);

Carro.obterValorIPVA();
Console.WriteLine($"Valor IPVA: {Carro.valorIPVA}");

/*
 
A palavra static é usada para declarar um membro de uma classe que pertence à própria classe, e não a uma instância específica da classe. 
Isso significa que o membro static é compartilhado por todas as instâncias da classe. Um membro static é chamado em relação à própria classe, 
e não a uma instância específica da classe.
 
 */

public class Carro
{

    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;
    public static double valorIPVA;

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