using Enumerations;

Console.WriteLine("## Enum ##\n\n");

Console.WriteLine($"{DiasDaSemana.Domingo} - {(int)DiasDaSemana.Domingo}");
Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine("Selecione a Categoria teclando o seu valor\n");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor;
Console.WriteLine($"Você selecionou a categoria : {nomeMembroEnum}");

BasicColor c;
c = BasicColor.red;
Console.WriteLine(c);

Console.ReadKey();

enum BasicColor{
    red,
    green,
    blue
}