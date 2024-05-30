while(true){
    Console.Write("\nInsira um número positivo que deseja saber a tabuada (Insira o número -101 para sair): ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num == -101)
        break;

    if(num <= 0)
        Console.WriteLine("\nInsira somente números positivos");
    else{
        Console.WriteLine();
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{num} * {i} = {num*i}");
    }
}