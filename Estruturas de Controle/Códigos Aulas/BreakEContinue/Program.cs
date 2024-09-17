Console.WriteLine("## Break e Continue ##\n");

for( ; ; ){

    Console.Write("Tecle algo(X e x sai): ");
    var input = Console.ReadLine();

    Console.WriteLine(input.ToUpper());

    if(input.ToUpper().Equals("X"))
        break;

}
Console.WriteLine();

for(int i = 1; i <= 10; i++){

    if(i % 2 != 0)
        continue;
    Console.WriteLine(i);

}
Console.WriteLine();

int b = 1;
while(b <= 10){

    if(b % 2 != 0){
        b++;
        continue;
    }

    Console.WriteLine(b++);

}
Console.WriteLine();

for (int i = 1; i <= 10; i++)
{

    if (i == 8)
        break;

    if (i % 2 != 0)
        continue;
    Console.WriteLine(i);

}
Console.WriteLine();
