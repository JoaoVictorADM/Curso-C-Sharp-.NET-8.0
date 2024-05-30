Console.WriteLine("## Conversão de tipos##\n");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine();

int valorInt1 = 10;
double valorDouble1 = 5.35;
bool valorBool1 = true;

Console.WriteLine(Convert.ToString(valorInt1));
Console.WriteLine(Convert.ToDouble(valorInt1));
Console.WriteLine(Convert.ToString(valorBool1));
Console.WriteLine(Convert.ToInt32(valorDouble1));
Console.WriteLine(Convert.ToBoolean(valorInt1));

valorInt1 = 0;

Console.WriteLine(Convert.ToBoolean(valorInt1));

valorInt1 = -1;

Console.WriteLine(Convert.ToBoolean(valorInt1));