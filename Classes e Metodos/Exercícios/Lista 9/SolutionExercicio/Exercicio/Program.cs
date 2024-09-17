/*
 
 - Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros :
Branco, Vermelho, Preto, Cinza, Prata e Azul

- Inicie o valor da enumeração com 1

- Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro

- Defina um menu de opções exibindo o nome da Cor e o seu valor

- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor

- Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da
cor a partir do valor da Cor recebida
 
 */


using Exercicio;

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");
Console.WriteLine("\nSelecione a Cor do carro");

int cor = Convert.ToInt32(Console.ReadLine());

Carro c1 = new("Sedan", "Chevrolet", "Onix", 2016, 110, cor);
c1.Acelerar(c1.marca);
Carro.ExibirInfo(c1.modelo, c1.montadora, c1.marca, c1.potencia, c1.cor);

public class Carro
{

    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;
    public int cor;

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia, int cor)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
        this.cor = cor;
    }

    public void Acelerar() =>
        System.Console.WriteLine("Acelerando...");

    public void Acelerar(string? marca) =>
        System.Console.WriteLine($"Acelerando meu {marca}");

    public static void ExibirInfo(string? modelo, string? montadora, string? marca, int potencia, int cor = 1, int ano = 2022)
    {
        Console.WriteLine(modelo);
        Console.WriteLine(montadora);
        Console.WriteLine(marca);
        Console.WriteLine(potencia);
        Console.WriteLine(ano);
        Console.WriteLine((Cores)cor);
    }
}