/*
l - Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado
potencia e retorna um int representando o aumento de potencia.
(para aumentar a potência incremente 3 ao parâmetro recebido)

m - Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o
comportamento da passagem do argumento por valor

n - Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
chamado potencia e retorna um int representando o aumento de potencia.
(para aumentar a potência incremente 5 ao parâmetro recebido)

p - Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o
comportamento da passagem do argumento por referência.

*/

int potencia = 10;

Carro c1 = new("Civic", "Honda", "Honda", 2020, 173);

Console.WriteLine($"Pontência do {c1.marca} {c1.modelo}: {c1.potencia}\n");

Console.WriteLine($"Valor Variavel Potencia \"Main\" antes do aumento por passagem por valor: {potencia}\n");

Console.WriteLine("Aumento da potência passando potencia como parâmetro\n");

c1.aumentarPotencia(potencia); /*Passagem por valor, não necessariamente porque estou passando um número direto
                                Quando eu passo uma passagem de parâmetro por valor é criado uma cópia do "objeto/valor"
                                e é passado para o método, então o método não altera o valor original, ele altera a cópia               
                                */

Console.WriteLine($"Pós Aumento - Pontência do {c1.marca} {c1.modelo}: {c1.potencia}\n");

Console.WriteLine($"Valor Variavel Potencia \"Main\" depois do aumento por passagem por valor: {potencia}\n");

Console.WriteLine();

Console.WriteLine($"Valor Variavel Potencia \"Main\" antes do aumento por passagem por referencia: {potencia}\n");

Console.WriteLine("Aumento da potência passando 10 como parâmetro por referência");

c1.aumentarPotencia(ref potencia); /*Passagem por referência, quando eu passo uma passagem de parâmetro por referência
                                    eu estou passando o endereço de memória da variável, então o método altera o valor
                                    original, e não uma cópia
                                    *                                                                                                          */

Console.WriteLine($"Pós Aumento - Pontência do {c1.marca} {c1.modelo}: {c1.potencia}\n");

Console.WriteLine($"Valor Variavel Potencia \"Main\" depois do aumento por passagem por valor: {potencia}\n");


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

    public int aumentarPotencia(int potencia){
        return this.potencia += potencia += 3;
    }

    public int aumentarPotencia(ref int potencia){
        potencia += 5;
        return this.potencia += potencia;
    }

    /*A palavra return é usada para retornar um valor de um método. Quando o método é chamado, o valor é retornado e a execução do método é interrompida.*/

}