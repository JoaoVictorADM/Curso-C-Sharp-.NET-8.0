/*

t- Crie um método chamado ExibirInfo() que retorna void e que utiliza os parâmetros : Modelo, Montadora,
Marca, Potencia e Ano e que exiba as informações destes atributos no console.

u- Para este método defina o parâmetro Ano como opcional e faça duas chamadas ao método usando o
conceito de argumentos nomeados não informando o ano na primeira chamada e informando o ano na segunda
chamada.

v- Explique o uso do parâmetro opcional e dos argumentos nomeados

*/

using System.Reflection;

Carro c1 = new("Civic", "Honda", "Honda", 2020, 173);

c1.exibirInfo(modelo: c1.modelo, montadora: c1.montadora,marca: c1.marca, potencia: c1.potencia, ano: c1.ano);
c1.exibirInfo(modelo: c1.modelo, montadora: c1.montadora, marca: c1.marca, potencia: c1.potencia);

/*
 
Parâmetros nomeados são quando você define para qual parâmetro quer passar o valor/objeto, não dependendo da ordem passada e sim do nome do parametro.

Já o parâmetro opcional é quando você define um valor padrão para um parâmetro, caso não seja passado um valor para ele, ele irá assumir o valor padrão,
caso seja passado um valor, ele irá assumir o valor passado. Não podemos defenir um parêmetro obrigatório após um parâmetro opcional.

void exemplo(int a, int b = 1, int c = 2)  Nesse exemplo para podermos passar um valor para 'a' e 'c' e não passar um valor para 'b' é necessário usar 
parâmetros nomeados   exemplo(a:1, c: 3);

 */

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

}