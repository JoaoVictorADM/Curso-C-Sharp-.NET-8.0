/*
 
Crie um programa em C# que sirva para pesquisar um array de valores inteiros. Para fazer isso, siga estas
etapas a seguir

a - Solicite via teclado o número de valores do array (deve ser um número inteiro)
b - Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
c - Solicite ao usuário um valor de um número inteiro a procurar no array
d - Exiba se o número informado existe no array de inteiros ou não
e - Repita até que o texto ‘fim’ seja inserido via teclado

*/

int tamVet = 0;

while(true){
    Console.Write("Insira o número de elentos do array(Inteiro): ");
    try{
        tamVet = Convert.ToInt32(Console.ReadLine());
    }catch(System.FormatException fe){
        Console.WriteLine(fe.Message + "\n");
    }
    Console.WriteLine();
    
    if(tamVet > 0)
        break;
}

int[] vetor = new int[tamVet];

for(int i = 0; i < tamVet; i++){
    Console.Write($"Insira o {i + 1}º valor do array: ");
    try{
        vetor[i] = Convert.ToInt32(Console.ReadLine());
    }catch(System.FormatException fe){
        Console.WriteLine(fe.Message + "\n");
        i--;
    }
}

Console.WriteLine();

while(true){

    Console.Write("Insira um número para buscar(digite \"fim\" para sair): ");
    string? entrada = Console.ReadLine();
    if(entrada.Equals("fim"))
        break;
    Console.WriteLine();

    int numBusca = 0;

    try{
        numBusca = Convert.ToInt32(entrada);
    } catch(System.FormatException fe){
        Console.WriteLine(fe.Message + "\n");
        continue;
    }

    Console.WriteLine($"O vetor {(vetor.Contains(numBusca) ? "" : "não ")}contém o número {numBusca}\n");


}