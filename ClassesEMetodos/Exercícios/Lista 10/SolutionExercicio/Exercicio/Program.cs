/*
 
- Explique como poderíamos substituir o método ObterValorIPVA() de forma a inicializar o campo estático
ValorIpva quando uma instância da classe fosse criada.

- Implemente o código que realiza essa substituição

- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para internal ?

- Qual o efeito de alterar o modificador de acesso do campo estático ValorIpva de public para private ?

 */


Carro c1 = new("Civic", "Honda", "Honda", 2020, 173);

/*
 
 Para inicializar o campo estático ValorIpva quando uma instância da classe fosse criada, poderíamos criar um construtor que inicializasse o campo estático ValorIpva.
 Exemplo static <NomeClass>() { <NomeCampo> = <Valor> }, esse construtor é chamado de construtor estático. É chamado apenas uma vez quando a classe é carregada na memória.
 
 */

/*
 
 O modificador internal faria com que o campo static só fosse acessado pela classe Carro mas somente no mesmo assembly

 */

/*
 
 O modificador private faria com que o campo static fosse acessado somente dentro da classe Carro 

 */


public class Carro
{

    public string? modelo;
    public string? montadora;
    public string? marca;
    private int ano;
    public int potencia;
    public static double valorIPVA;

    public int Ano
    {

        get { return this.ano; }

        set
        {

            if (value < 2000)
                this.ano = 2000;
            else if (value > 2022)
                this.ano = 2022;
            else
                this.ano = value;


        }

    }

    static Carro(){
        Carro.valorIPVA = 4.0;
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