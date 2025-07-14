/*
 
5- Imagine que você precisa criar um método que imprima na tela os números pares de uma lista de inteiros
de 1 a 20.

Para isso, você deve utilizar um delegate Action<int> que receba um número inteiro como parâmetro e
imprima na tela apenas os números pares.

*/

namespace Exercicio5;

public class Program{
    public static void Main(string[] args){

        List<int> numeros = new (){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        Action<int> printPar = (num) => {
            if (num % 2 == 0)
                Console.WriteLine(num);
        };

        numeros.ForEach(printPar);
    }
}
