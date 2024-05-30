// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("## Estrutura Switch Case ##\n");

int compra = 600;
Console.WriteLine($"Valor da compra R$ {compra}");
Console.Write("Informe o número de parcelas(1 a 3): ");
int numParcelas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch(numParcelas){
    case 1:
        Console.WriteLine($"Prestação {numParcelas}x{compra/numParcelas}\n");
    break;
    case 2:
        Console.WriteLine($"Prestação {numParcelas}x{compra / numParcelas}\n");
    break;
    case 3:
        Console.WriteLine($"Prestação {numParcelas}x{compra / numParcelas}\n");
    break;
    default:
        Console.WriteLine("Número de parcelas inválido");
    break;
}

Console.Write("Informe um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

switch(num % 2)
{
    case 0:
        Console.WriteLine("Número par\n");
    break;
    case 1:
        Console.WriteLine("Número ímpar\n");
    break;
}

Console.Write("Informe o nome do mês: ");
string mes = Console.ReadLine().ToLower();
Console.WriteLine();

switch(mes){
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Esse mês tem 31 dias\n");
    break;

    case "fevereiro":
        Console.WriteLine("Esse mês tem 28 ou 29 dias\n");
    break;

    default:
        Console.WriteLine("Esse mês tem 30 dias\n");
    break;
}



Console.Write("Você é Gerente(1) ou Programador(2): ");
int cargo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int funcao = 0;

if(cargo == 2)
{
    Console.Write("Você é Junior(1) ou Senior(2): ");
    funcao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

switch (cargo)
{
    case 1:
        Console.WriteLine("Gerente");
    break;

    case 2:
        Console.Write("Programador ");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Junior");
            break;
            case 2:
                Console.WriteLine("Senior");
            break;
            default:
                Console.WriteLine("Função inválida");
            break;
        }
    break;

    default:
        Console.WriteLine("Cargo inválido");
    break;
}