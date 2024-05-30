int i = 10;

for( ; i <= 20; i += 2)
    if(i != 16)
        Console.Write(i + " ");
Console.WriteLine();

for (i = 10; i <= 20; i++){
    if (i == 16)
        continue;
    if(i % 2 == 0)
        Console.Write(i + " ");
}
Console.WriteLine();

i = 10;

while(true){

    if(i == 16){
        i++;
        continue;
    }
    
    if(i > 20)
        break;

    if (i % 2 == 0)
        Console.Write(i + " ");
    i++;
}


