/*
 
1 - Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
potencia com os tipos de dados string, string, string, int e int.
Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”
 
 */

/*
 
a - Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet , Onix, 2016, 110

*/


Carro chevrolet = new();
chevrolet.modelo = "Sedan";
chevrolet.montadora = "Chevrolet";
chevrolet.marca = "Onix";
chevrolet.ano = 2016;
chevrolet.potencia = 110;

//Carro chevrolet = new(){
//    modelo = "Sedan",
//    montadora = "Chevrolet",
//    marca = "Onix",
//    ano = 2016,
//    potencia = 110
//}

/*
 
b - Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120

*/

Carro ford = new();
ford.modelo = "SUV";
ford.montadora = "Ford";
ford.marca = "EcoSport";
ford.ano = 2018;
ford.potencia = 120;

/*
 
c - Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar
para cada objeto 

*/

System.Console.WriteLine($"Chevrolet: {chevrolet.modelo} {chevrolet.montadora} {chevrolet.marca} {chevrolet.ano} {chevrolet.potencia}");
chevrolet.acelerar();

System.Console.WriteLine($"Ford: {ford.modelo} {ford.montadora} {ford.marca} {ford.ano} {ford.potencia}");
ford.acelerar();

/*
 
d - Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.

*/

chevrolet.acelerar(chevrolet.marca);
ford.acelerar(ford.marca);

/*
 
e - Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe) 

*/

/*

f - Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o
método Acelerar passando o valor do argumento para o parâmetro no método Acelerar 

*/

Carro chevrolet1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford1 = new("SUV", "Ford", "EcoSport", 2018, 120);

chevrolet1.acelerar(chevrolet1.marca);
ford1.acelerar(ford1.marca);

// Classe Carro

public class Carro{

    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro(){ 

    }

    public Carro(string modelo, string montadora, string marca, int ano, int potencia){
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

}