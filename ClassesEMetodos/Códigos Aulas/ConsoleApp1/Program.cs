Console.WriteLine("## Métodos com Retorno ##\n");

Calculadora c = new();

Console.WriteLine(c.somar(4, 2));
Console.WriteLine(c.subtrair(4, 2));
Console.WriteLine(c.multiplicar(4, 2));
Console.WriteLine(c.dividir(4, 2));

public class Calculadora{

    public double somar(double n1, double n2){
        return n1 + n2;
    }

    public double subtrair(double n1, double n2){
        return n1 - n2;
    }

    public double multiplicar(double n1, double n2){
        return n1 * n2;
    }

    public double dividir(double n1, double n2){

        if (0 != n2)
            return n1 / n2;

        Console.WriteLine("Impossível dividir por zero\n");
        return -1;

    }

}
