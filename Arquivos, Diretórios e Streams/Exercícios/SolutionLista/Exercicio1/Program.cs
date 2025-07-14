/*
1- Escreva um programa que leia um caminho de arquivo do usuário e, em seguida, verifique se o arquivo
existe. Se o arquivo existir, mostre a data de criação do arquivo, caso contrário, exiba uma mensagem
informando que o arquivo não foi encontrado.
 
*/

Console.Write("Insira o nome do arquivo: ");
string caminhoArquivo = Console.ReadLine();
Console.WriteLine();

if(File.Exists(caminhoArquivo))
    Console.WriteLine($"O arquivo foi criado em: {File.GetCreationTime(caminhoArquivo)}");
else
    Console.WriteLine("Arquivo não encontrado.");
