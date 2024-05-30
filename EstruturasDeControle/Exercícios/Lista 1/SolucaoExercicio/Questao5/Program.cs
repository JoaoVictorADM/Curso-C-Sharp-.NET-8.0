char resposta = 'C';
bool acertou = false;

while (!acertou && resposta != 'x'){

    Console.WriteLine("Qual a instrução para sair de um loop ? (Tecle x para sair): ");
    Console.WriteLine("a.quit");
    Console.WriteLine("b.continue");
    Console.WriteLine("c.break");
    Console.WriteLine("d.exit");

    Console.Write("Insira a letra da sua resposta: ");
    resposta = Convert.ToChar(Console.ReadLine().ToLower());

    if(resposta == 'c'){
        acertou = true;
        Console.WriteLine("\nParabens você acertou. A resposta correta é a letra c: break\n");
    }
    else if(resposta != 'x')
        Console.WriteLine("\nResposta incorreta. Tente novamente\n");

}


