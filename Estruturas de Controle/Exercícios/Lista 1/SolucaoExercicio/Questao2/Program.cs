Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c):\n");
Console.Write("Informe o valor de a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de c:");
int c = Convert.ToInt32(Console.ReadLine());

int delta = (b * b) - (4 * a * c);

if(delta < 0)
    Console.WriteLine("\nAs raízes são imaginárias;\nSem solução para os números reais.");
else{
    double mais = (-b + Math.Sqrt(delta)) / 2 * (double)a;

    if(delta == 0)
        Console.WriteLine($"As raízes são iguais\nx = {mais}");
    else{
        double menos = (-b - Math.Sqrt(delta)) / 2 * (double)a;
        Console.WriteLine($"\nAmbas as raízes são reais e diferentes\nPrimeira raiz x1 = {mais}\nSegunda raiz x2 = {menos}");
    }
}
  





