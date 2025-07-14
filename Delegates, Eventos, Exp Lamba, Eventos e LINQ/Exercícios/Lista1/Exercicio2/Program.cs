/*
2 - Implemente um programa que use delegates para somar dois números inteiros. O programa deve seguir
as seguintes especificações:

 a - Defina um delegate chamado OperacaoMatematica que recebe dois inteiros como parâmetros e retorna
um inteiro.

 b-Defina um método que implementam a operação de soma: que recebe os dois inteiros como parâmetros

 c-Crie um objeto delegate do tipo OperacaoMatematica e atribua a ele ao método definido.

 d-Chame o delegate passando os parâmetros necessários e exiba o resultado da operação na tela.

Dica: Utilize o método Invoke do delegate para invocar a operação matemática.
*/

using System.Threading.Channels;

namespace Exercicio;

public delegate int OperacaoMatematica(int a, int b);

public class Program{

    public static void Main(string[] args){

        OperacaoMatematica soma = (int a, int b) => a + b;
        Console.WriteLine($"Resultado da soma: {soma.Invoke(5, 10)}");

    }

}

