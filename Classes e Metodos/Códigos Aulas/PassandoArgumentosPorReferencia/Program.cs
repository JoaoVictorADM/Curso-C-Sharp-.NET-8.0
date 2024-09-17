Console.WriteLine("## Passando argumentos por referência ##\n\n");

int x = 20;

Console.WriteLine($"Valor do argumento x antes de passar por valor {x}\n");

Calculo c = new();
c.dobrar(ref x);

Console.WriteLine($"Valor do argumento x depois de passar por valor {x}\n");

Console.ReadKey();

public class Calculo{
    public void dobrar(ref int y){
        y *= 2;
        Console.WriteLine("$Valor do parâmetro y no método Dobrar {y}\n");
    }
}

