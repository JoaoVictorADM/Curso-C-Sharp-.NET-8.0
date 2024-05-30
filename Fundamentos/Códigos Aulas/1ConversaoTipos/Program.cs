Console.WriteLine("## Conversão de tipos##\n");

/*--------Conversões Implícitas--------*/
Console.WriteLine("--------Conversões Implícitas--------\n");

int varInt = 100;
double varDouble = varInt;

Console.WriteLine(varDouble);
Console.WriteLine();

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);
Console.WriteLine();

/* Erro de compilação, essa conversão implícita não pode ocorrer
    double varDouble = 12.456; 8bytes
    int varInt1 = varDouble; 4bytes
*/

/*--------Conversões Explícitas--------*/
Console.WriteLine("--------Conversões Explícitas--------\n");

double varDouble1 = 12.456; 
int varInt1 = (int)varDouble1;

Console.WriteLine(varInt1);
Console.WriteLine();

int num1 = 10;
int num2 = 4;

float resultado1 = num1 / num2;

Console.WriteLine(resultado1);

float resultado = num1 / (float)num2;

Console.WriteLine(resultado);




