using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("## Nullable Types ##\n");

        Nullable<int> teste00 = null;
        Nullable<bool> teste01 = null;
        Nullable<decimal> teste02 = null;

        Console.WriteLine(teste00);
        Console.WriteLine(teste01);
        Console.WriteLine(teste02);

        // Simplificação declaração Nullable

        int? teste10 = null;
        int? teste11 = null;
        int? teste12 = null;

        Console.WriteLine(teste10);
        Console.WriteLine(teste11);
        Console.WriteLine(teste12);

        int varTeste = 10;

        /*
         
            Isso pode: teste10 = varTeste
        
            Isso não pode: varTeste = teste10;

         
         */

        teste10 = varTeste;

        Console.WriteLine(teste10);
        Console.WriteLine();

        /*
         
            Para contornar esse problema de atribuição podemos usar o operador ??

            Exemplo: varTeste = teste10 ?? 0;

            Isso significa que se o valor de teste10 for null ele atribui 0 para varTeste, e se não for null atribui o proprio valor de teste10 para varTeste
         
         */

        int varTeste1;

        varTeste1 = teste10 ?? 0;

        Console.WriteLine(varTeste1);
        Console.WriteLine();

        varTeste1 = teste00 ?? 0;

        Console.WriteLine(varTeste1);
        Console.WriteLine();

        /*                                            */

        int? x = 10;
        int y = 2;

        Console.WriteLine((x ?? 1) * y);
        Console.WriteLine();

        x = null;

        Console.WriteLine((x ?? 1) * y);
        Console.WriteLine();

        x = 10;

        if(x.HasValue)
            Console.WriteLine($"x tem um valor e é: {x}");
        else
            Console.WriteLine("x não tem um valor, portanto é null");

        Console.WriteLine();

        x = null;

        if (x != null)
            Console.WriteLine($"x tem um valor e é: {x}");
        else
            Console.WriteLine("x não tem um valor, portanto é null");

    }
}