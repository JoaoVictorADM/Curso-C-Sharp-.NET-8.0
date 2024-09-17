Console.Write("Insira o número de linhas do triângulo retângulo: ");
int linhas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for(int i = 1; i <= linhas; i++){ 
    for(int j=0; j < i; j++)
        Console.Write("*");
    Console.WriteLine();
}
