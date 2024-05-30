Console.WriteLine("Operadores de atribuição\n");

float x = 5;
x = 10;

Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x+=5 ==> {x+=5}");
Console.WriteLine($"x-=5 ==> {x-=3}");
Console.WriteLine($"x*=5 ==> {x*=4}");
Console.WriteLine($"x/=5 ==> {x/=5}");
Console.WriteLine($"x%=5 ==> {x%=5}\n");

string y = "";

Console.WriteLine($"Valor inicial de y = {y}");
Console.WriteLine($"y+=\"456\" ==> {y+="456"}");

var y1 = "123";

Console.WriteLine($"Valor inicial de y1 = {y1}");
Console.WriteLine($"y1+=\"456\" ==> {y1 += "456"}");
