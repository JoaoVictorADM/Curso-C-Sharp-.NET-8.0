int[,] a = new int[3, 3];

for(int i = 0; i < 3; i++){
    for(int j = 0; j < 3; j++){
        a[i, j] = (i * 3) + j;
        Console.Write($"a[{i}][{j}]: {a[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for(int i = 0; i < a.GetLength(0); i++){
    for(int j = 0; j < a.GetLength(1); j++){
        a[i, j] = (i * 3) + j;
        Console.Write($"a[{i}][{j}]: {a[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

foreach(int numero in a){
    Console.Write($"{numero} ");
}



