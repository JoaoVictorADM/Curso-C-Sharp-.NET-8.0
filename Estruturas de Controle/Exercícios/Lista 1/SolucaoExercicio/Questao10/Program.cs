while(true){

    Console.Write("Insira a nota do aluno (-101 para sair): ");
    int nota = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    if(nota == -101)
        break;
    
    switch(nota){

        case 1:
        case 2:
        case 3:
        case 4:
            Console.WriteLine("F");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case 7:
        case 8:
            Console.WriteLine("B");
            break;
        case 9:
            Console.WriteLine("A");
            break;
        case 10:
            Console.WriteLine("A+");
            break;
        default:
            Console.WriteLine("Nota inválida");
            break;
    }
    Console.WriteLine();

}
