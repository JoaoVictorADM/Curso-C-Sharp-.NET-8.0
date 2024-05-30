// Questão 1

byte idade = 25;
Console.WriteLine($"Questão 1\nIdade : {idade}\n");

// Questão 2

string nome = "Maria";
Console.WriteLine($"Questão 2\nNome : {nome}\n");

// Questão 3

double altura = 3.45;
Console.WriteLine($"Questão 3\nAltura : {altura}\n");

// Questão 4

DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine($"Questão 4\nData : {data}\n");

// Questão 5

const byte ANO = 12;
Console.WriteLine($"Questão 5\nAno : {ANO}\n");

// Questão 6

double? nota = 7.8;
Console.WriteLine($"Questão 6\nNota : {nota}\n");

/* Questão 7


    Quais as diferenças entre os tipos por valor e os tipos por referência?

    R: Tipos por valor: Armazenam um valor em si, onde são armazenados na memória stack e cada variável tem um cópia do dado
    Tipos por referência: Armazena o endereço de onde o valor está armazenado. Tipo por referência é um "ponteiro", são armazenadas na memória heap.
    
*/

/* Questão 8
 
    Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:

    (byte) x= 10
    (double) numero = 7.99;
    (char) letra = 'C';
    (float) temperatura = 27.4f;
    (bool) ativo = false;
    (string) nome = "Manoel";
    (decimal) salario = 950.99m;
    (DateTime) hoje = DateTime.Now;


*/

/* Questão 9
 
    Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) :

    (V) int n = 1;
    (R) string titulo = "A vida";
    (V) float f = 12.45f;
    (V) double d = 5.45;
    (V) decimal valor = 10.99m;
    (V) char sexo = 'M';
    (R) object o = null;

*/

/* Questão 10
  
    O que é um nullable type e qual a sua utilidade?

    R: É um tipo de variável que aceita null, ausencia de valor. Serve para casos onde a variável possa ter um valor ou não.
    Ex: um tabela hash feita usando um vetor, ao invés de inicializar todas a posições com um número que você acha que não será utilizado, você inicializa como null,
    dizendo que não tem número naquela posição. Também pode ser usado quando temos integração com banco de dados, pois as vezes algum campo de determinada tabela pode
    não ter obrigatoriedade de preenchimento, deixando o campo com valor null.

*/

/* Questão 11

    O que é Camel Case ? Dê um exemplo de sua aplicação;

    R: Camel Case é um convenção utilizada para indeticadores compostos, como o identificadores de variáveis, onde a primeira letra de todas as palavras deve ser maiúscula, exceto a da primeira palavra
    Ex: decimal porcentagemDeDesconto = 0.3550m;

*/

/* Questão 12
    
    O que é Pascal Case ? Dê um exemplo de sua aplicação.

    R: Pascal Case é um convenção utilizada para nomeação de de Classes, Métodos e etc, onde a primeira letra de todas as palavras devem ser maiúsculas.
    Ex: Class Program{

            public void GerarRelatorio(){

            }

        }

*/

// Questão 13

int x = 77, y = 66;
Console.WriteLine($"Questão 13\nSoma X + Y : {x + y}\n");

/* Questão 14

    Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.

    bool - false
    char - '\0'
    int - 0
    double - 0
    float - 0
    decimal - 0
    string - null

*/

/* Questão 15

    Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada:
    
    (F) double 1valor = 12.45; 
    (F) string #nome = "Pedro"; 
    (V) float _temperatura = 12.45f; 
    (F) double int = 5; 
    (F) decimal renda extra = 91.45m;
    (F) bool status$conta = false;
    (V) string titulo3 = “Tópico 1”; 
    (V) float salario_mensal = 1999.55f;
    (V) int percentualValorDesconto = 5;
    (V) const bool MENSALIDADE_EM_DIA = true;

*/

