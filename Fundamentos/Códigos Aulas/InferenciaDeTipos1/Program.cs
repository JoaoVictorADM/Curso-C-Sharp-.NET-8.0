Console.WriteLine("## Inferência de tipos ##\n");

int idade = 25;
string nome = "Maria";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}\n");

var idade1 = 25;
var nome1 = "Maria";
var salario1 = 2500.00m;

Console.WriteLine($"{nome1} tem {idade1} anos e ganha {salario1.ToString("c")}\n");

/* Limitações do var
    
var salario = null;
var titulo;
var salario, imposto, total;

//Não é possível mudar o tipo da variável depois de declarada

var num = 10;
num =  num + 20;
num = "Teste"; //Erro

*/

var teste = new Teste();
teste.MeuMetodo();

class Teste{

    public void MeuMetodo(){
        Console.WriteLine("Meu Método");
    }

}