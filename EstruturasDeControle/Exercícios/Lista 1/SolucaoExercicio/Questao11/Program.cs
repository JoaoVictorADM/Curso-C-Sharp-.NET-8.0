while(true){

    Console.Write("Informe o primeiro número (Informe -101 para sair): ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    if(num1 == -101)
        break;

    char operando;
    do{
        Console.Write("\nInforme o operando (+, -, /, *):");
        operando = Convert.ToChar(Console.ReadLine());
    } while ((operando != '+') && (operando != '-') && (operando != '/') && (operando != '*'));

    Console.Write("\nInforme o segundo número (Informe -101 para sair): ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if (num2 == -101)
        break;

    switch (operando){

        case '+':
            Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}\n");
            break;
        case '-':
            Console.WriteLine($"\n{num1} - {num2} = {num1 - num2}\n");
            break;
        case '/':
            Console.WriteLine($"\n{num1} / {num2} = {num1 / num2}\n");
            break;
        case '*':
            Console.WriteLine($"\n{num1} * {num2} = {num1 * num2}\n");
            break;
    }

}
