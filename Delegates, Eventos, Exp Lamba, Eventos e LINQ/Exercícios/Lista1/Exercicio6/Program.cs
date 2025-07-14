/*
6- Crie um programa onde um método que receba dois números inteiros e retorne o resultado da operação
de adição ou subtração desses números, a ser definida em tempo de execução por um delegate Func<int, int,
int>.
*/ 

public class Program{

    public static void Main(string[] args){

        Func<int, int, int>  soma = (int a, int b) => a + b;

        int a = 5;
        int b = 10;

        Console.WriteLine($"Resultado para {a} + {b} = {soma.Invoke(a, b)}");

    }

}