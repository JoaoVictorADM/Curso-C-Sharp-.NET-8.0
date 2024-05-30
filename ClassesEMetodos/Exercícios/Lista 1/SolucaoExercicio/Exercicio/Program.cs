using System;
using System.Globalization;

Carro chevrolet = new();
chevrolet.modelo = "Sedan";
chevrolet.montadora = "Chevrolet";
chevrolet.marca = "Onix";
chevrolet.ano = 2016;
chevrolet.potencia = 110;

Carro ford = new()
{
    modelo = "SUV",
    montadora = "Ford",
    marca = "EcoSport",
    ano = 2018,
    potencia = 120
};

Console.WriteLine($"Modelo: {chevrolet.modelo} - Montadora: {chevrolet.montadora} - Marca: {chevrolet.marca} - Ano: {chevrolet.ano} - Potência: {chevrolet.potencia}");
chevrolet.Acelerar1();

Console.WriteLine($"Modelo: {ford.modelo} - Montadora: {ford.montadora} - Marca: {ford.marca} - Ano: {ford.ano} - Potência: {ford.potencia}");
ford.Acelerar1();

chevrolet.Acelerar2(chevrolet.marca);
ford.Acelerar2(ford.marca);
Console.WriteLine();

Carro chevrolet1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford1 = new("SUV", "Ford", "EcoSport", 2018, 120);

chevrolet1.Acelerar2(chevrolet1.marca ?? "");
ford1.Acelerar2(ford1.marca ?? "");


public class Carro{

    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro(){
        
    }   

    public Carro(string? modelo, string? montadora, string? marca, int ano, int potencia){
        this.modelo = modelo;
        this.montadora = montadora; 
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public void Acelerar1(){
        System.Console.WriteLine("Acelerando...\n");
    }

    public void Acelerar2(string marca){
        Console.WriteLine($"Acelerando meu {marca}\n");
    }

}