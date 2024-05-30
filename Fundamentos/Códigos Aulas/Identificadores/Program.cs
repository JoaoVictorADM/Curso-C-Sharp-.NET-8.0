Console.WriteLine("Definindo Identificadores\n");

// Indentificadores válidos

string nome;
string nomeCompleto;
int idade1;
int _valorCompra;

// Indentificadores inválidos

/*
 *  int 5idade;
 *  int $valorCompras;
 *  int valor#total;
 *  string nome Completo;
 *  
 */

// Para constantes usar letras maiúsculas 

const decimal PI = 3.14159265m;
const float EULER = 2.718281828f;

// Para nomes de variáveis usar camel case

float descontoTotal = 204.24f;
decimal porcentagemDeDesconto = 0.3525m;

// Para nome de classes e métodos usar pascal case

class ImprimirTexto1{
    public void ImprimeNome(string nome){
        Console.WriteLine(nome);
    }
}
