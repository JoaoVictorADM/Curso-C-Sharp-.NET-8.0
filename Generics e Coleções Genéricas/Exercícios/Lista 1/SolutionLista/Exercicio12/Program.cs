int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
string[] array2 = { "João", "Rafael", "Lucas" };
double[] array3 = { 4.3, -10.3, 20.4 };

Console.WriteLine("-Array de Inteiros:");
Exemplo.ReverterEImprimir<int>(array1);
Exemplo.ReverterEImprimir(array1);

Console.WriteLine("\n -Array de Strings:");
Exemplo.ReverterEImprimir<string>(array2);
Exemplo.ReverterEImprimir(array2);

Console.WriteLine("\n-Array de Doubles:");
Exemplo.ReverterEImprimir<double>(array3);
Exemplo.ReverterEImprimir(array3);

class Exemplo{
    public static void ReverterEImprimir<T>(T[] array){

        Array.Reverse(array);

        Console.WriteLine("Array Revertido:");

        foreach(T item in array)
            Console.Write($"{item} ");
        
        Console.WriteLine();
    }
}