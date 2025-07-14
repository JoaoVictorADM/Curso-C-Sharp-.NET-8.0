/*
Dado o código abaixo, assinale com verdadeiro ou falso cada afirmação sobre os delegates Action,
Predicate e Func da linguagem C#:

int[] numeros = { 1, 2, 3, 4, 5 };

// Delegate Action
Action<int> exibirNumero = num => Console.WriteLine(num);
Array.ForEach(numeros, exibirNumero);

// Delegate Predicate
Predicate<int> ehPar = num => num % 2 == 0;
bool todosPares = Array.TrueForAll(numeros, ehPar);

// Delegate Func
Delegates , Lambda, LINQ
Func<int, int, int> somar = (a, b) => a + b;
int resultado = somar(10, 20);
Console.WriteLine(todosPares);
Console.WriteLine(resultado);
Console.ReadKey();

a - O delegate Action é usado para encapsular um método que recebe um parâmetro e não retorna nenhum
valor. (Verdadeiro ou Falso)

b - O método Array.ForEach é usado para percorrer todos os elementos de um array e executar um delegate
para cada um deles. (Verdadeiro ou Falso)

c - O delegate Predicate é usado para encapsular um método que recebe um parâmetro e retorna um valor
booleano. (Verdadeiro ou Falso)

 d - O método Array.TrueForAll retorna true se todos os elementos de um array satisfazem uma condição
especificada por um delegate. (Verdadeiro ou Falso)

 e - O delegate Func é usado para encapsular um método que recebe um ou mais parâmetros e retorna um
valor. (Verdadeiro ou Falso)

 f - O delegate Func pode ter até 16 parâmetros de entrada e um tipo de retorno genérico. (Verdadeiro ou
Falso)

 g - No exemplo acima, o delegate Func é usado para definir um método que soma dois números inteiros.
(Verdadeiro ou Falso)

 h - No exemplo acima, o método somar recebe dois parâmetros e retorna um valor. (Verdadeiro ou Falso)
*/

bool a = true;  
bool b = true;
bool c = true;
bool d = true;
bool e = true;
bool f = false;
bool g = true;
bool h = true;
