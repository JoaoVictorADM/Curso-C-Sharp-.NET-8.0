int[] nums1 = { 1, 2, 3 };

Console.WriteLine($"Soma Array 1: {Calcular.soma(nums1)}\n");

Console.WriteLine($"Soma usando params: {Calcular.soma(1, 2, 3, 4, 5)}\n");
public class Calcular{

    public static int soma(params int[] numeros){

        int soma = 0;

        foreach (int numero in numeros)
            soma += numero;

        return soma;

    }

}
