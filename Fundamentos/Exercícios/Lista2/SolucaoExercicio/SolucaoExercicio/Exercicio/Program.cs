using System;

/* Questão 1
 
Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : 
Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.
 
*/

Console.WriteLine("---------QUESTÃO 1---------\n");
string nome = "Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota + "\n");

/* Questão 2
 
Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de 
escapes.
 
 */
Console.WriteLine("---------QUESTÃO 2---------\n");
Console.WriteLine($"{nome}\n{idade}\n{nota}\n");

/* Questão 3

Para qual tipo de dados você pode converter um float implicitamente ?

() int 
(x) double
() long
(X) decimal

*/

/* Questão 4

Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ? 

() int para long
(X) double para long
(X) double para float
(X) decimal para float
(X) long para int
(X) double para decimal

*/

/* Questão 5
 
Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
a concatenação e também a interpolação de strings

 
*/

Console.WriteLine("---------QUESTÃO 5---------\n");

char letra1, letra2, letra3;

Console.WriteLine("Informe uma letra");
letra1 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Informe uma letra");
letra2 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Informe uma letra");
letra3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine($"{letra3} {letra2} {letra1}");
Console.WriteLine(letra3 + " " + letra2 + " " + letra1);

/* Questão 6
 
Marque verdadeiro(V) ou falso(F) para os códigos abaixo:

(F) long resultado = 1.32;
(V) var nome = “Maria”;
(V) string resultado = 100.ToString();
(V) A sequência de escape \n inclui uma nova linha
(F) float f = 5.45; 
(V) decimal valor = (decimal) 10.99f;
(F) var status = null;
(V) object o = 12.45m;
(V) string titulo = true.ToString(); 
(F) A sequencia \t inclui uma tabulação vertical
 
 */

/* Questão 7

Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
exibindo o resultado:
 
*/

Console.WriteLine("---------QUESTÃO 7---------\n");

double x, y;

x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"x + y = {x+y}");
Console.WriteLine($"x - y = {x-y}");
Console.WriteLine($"x * y = {x*y}");
Console.WriteLine($"x ^ y = {Math.Pow(x, y)}");
Console.WriteLine($"x / y = {x/y}");
Console.WriteLine($"x % y = {x%y}");

/* Questão 8
 
Faça um programa para calcular o resultado da fórmula de baskara dados os valores de 
a b e c. Valores : a = 1 , b = 12 e c = -13
 
*/

Console.WriteLine("---------QUESTÃO 8---------\n");

int a = 1, b =12, c = -13;

Console.WriteLine((-b + Math.Sqrt((b*b) - 4*a*c))/2*a);
Console.WriteLine((-b - Math.Sqrt((b * b) - 4 * a * c)) / 2 * a);
Console.WriteLine();

/* Questão 9
 
Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e 
Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ 
então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login 
inválido’: (use o operador condicional ternário)

 
*/

Console.WriteLine("---------QUESTÃO 9---------\n");

Console.Write("Insira o usuário: ");
string usuario = Console.ReadLine();
Console.Write("\nInsira a senha: ");
int senha = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine((usuario == "admin" || usuario == "maria") && senha == 123 ? "Login feito com sucesso" : "Login inválido");
Console.WriteLine();

/* Questão 10
 
Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando 
a nomenclatura usada:

(V) string? nome; é um exemplo de nullable reference type;
(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
(F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
(F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"
 
 */

/* Questão 11
 
Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :
 
*/

Console.WriteLine("---------QUESTÃO 11---------\n");

int x1, y1;

Console.Write("Digite um número x: ");
x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nDigite um número y: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{x1} é " + ((x1 % 2 == 0) ? "par" : "impar"));
Console.WriteLine($"{y1} é " + ((y1%2==0) ? "par": "impar"));

/* Questão 12
 
Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no 
console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415) 

6 + x * 5
(13-2) * x
(x + -2) * (20 / x)
(12 + x) / (x - 4)
3 x^2 + x + 10
pi * x^2

*/

Console.WriteLine("---------QUESTÃO 12---------\n");

Console.Write("Insira um valor x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine(6 + x * 5);
Console.WriteLine((13 - 2) * x);
Console.WriteLine((x + -2) * (20 / x));
Console.WriteLine((12 + x) / (x - 4));
Console.WriteLine(3 * x * x + x + 10);
Console.WriteLine(3.1415 * x * x);
Console.WriteLine();

/* Questão 13
 
Considere o seguinte trecho de código:
int y = 5 ;
y = (y++)+y+(++y); ou y = y++ + y + ++y;
Console.WriteLine(y);

Qual será o valor de y após a execução do código acima ? 

R: O resultado será 18
 
*/

/* Questão 14
 
Escreva um programa que solicite a temperatura em graus Celsius e converta para 
Kelvin e Farhenheit usando as fórmulas a seguir:
- Converter para Kelvin => K = C + 273 ;
- Converter para Farhenheit => F = (C * 9) / 5 + 32 ;


*/

Console.Write("Insira um tempera em Celsius: ");
double temperatura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"{temperatura} Celsius equivale a {temperatura + 273} Kelvin ou {(temperatura * 9)/5 + 32} Farhenheit");

/* Questão 15
 
Escolha a opção que representa a exibição do resultado para o código usando os 
operadores de decremento e incremento (pré e pós): 

var numero = 5;
Console.WriteLine(numero++);
numero = 1;
Console.WriteLine(++numero);
numero = 2;
Console.WriteLine(numero--);
numero = 3;
Console.WriteLine(--numero);
Console.ReadKey();

(X) 5 2 2 2
() 6 3 2 2
() 5 2 1 2
() 6 2 1 3
 
*/


