﻿Console.WriteLine("## Argumentos por referência - out");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo c = new();

double perimetro = c.calculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Perímetro da Circunferencia {perimetro}");
Console.WriteLine($"Área da Circunferência : {area}");

Console.ReadKey();

public class Circulo{
    public double calculaAreaPerimetro(double raio, out double area){
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}
