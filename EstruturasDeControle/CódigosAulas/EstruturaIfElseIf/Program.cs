Console.WriteLine("## Instrução If-Else-If ##\n");

Console.Write("Informe a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write("Aluno ");

if (nota < 5)
    Console.WriteLine("reprovado\n");
else if(nota >= 5 && nota < 6)
    Console.WriteLine("em recuperação\n");
else if(nota >= 6 && nota <= 9)
    Console.WriteLine("aprovado\n");
else
    Console.WriteLine("aprovado com distinção\n");