Console.WriteLine("Tabuado do 2 ao 6\n");

int i = 2, j = 1;

while(i <= 6){

    j = 1;

    while(j <= 10){
        Console.WriteLine($"{i} x {j} = {i*j}");
        j++;
    }

    Console.WriteLine();
    i++;
}
