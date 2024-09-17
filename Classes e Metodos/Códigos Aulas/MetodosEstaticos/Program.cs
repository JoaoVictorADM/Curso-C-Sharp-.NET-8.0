Console.WriteLine("## Métodos estáticos ##\n");

var soma = Calculadora.somar(10, 10);
var subtrair = Calculadora.subtrair(10, 10);
var multiplicar = Calculadora.multiplicar(10, 10);
var dividir = Calculadora.dividir(10, 10);

Console.WriteLine(soma);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.ReadKey();

public class Calculadora{
    public static int somar(int n1, int n2){
        return n1 + n2;
    }
    public static int subtrair(int n1, int n2){
        return n1 - n2;
    }
    public static int multiplicar(int n1, int n2){
        return n1 * n2;
    }
    public static int dividir(int n1, int n2){
        return n1 / n2;
    }

}