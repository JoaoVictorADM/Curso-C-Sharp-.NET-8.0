Console.WriteLine("## Constantes ##");

const int ANO = 12;

const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / MESES_ANO;

Console.WriteLine(ANO + " " + MES + " " + SEMANA + " " + QUINZENA + " " + DIAS_POR_MES); 

const double PI = Math.PI;
double perimetro, area, raio;

Console.WriteLine("Cálculo da Área e Perímetro de um círculo");
raio = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

area = PI * raio * raio;
perimetro = 2 * PI * raio;

Console.WriteLine($"Área = {area}");
Console.WriteLine($"Perímetro = {perimetro}");