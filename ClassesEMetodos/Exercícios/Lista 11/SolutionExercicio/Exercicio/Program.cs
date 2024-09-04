/*
 
1 - O que é uma classe e qual a sua composição ?

2 - O que é um objeto e como pode ser criado ?

3 - Qual a diferença entre classe e objeto ?

4 - O que é um método e como pode ser criado e chamado ?

5 - O que é um parâmetro de método ?

6 - O que é um argumento ?

7 - O que é um construtor e qual o seu objetivo ?

8 - Quais os usos da palavra chave this ?

9 - O que é um método com retorno ?

10 - O que é sobrecarga de método ?

11 - Como é feita a passagem de parâmetros por valor ?

12 - Como é feita a passagem de parâmetros por referência ?

13 - Qual a diferença entre os parâmetros out e o parâmetro ref ?

14 - O que são argumentos nomeados ?

15 - O que são parâmetros opcionais ?

16 - Qual o efeito da palavra-chave static ?

17 - O que é método estático e qual o seu comportamento ?

18 - O que é um campo estático e qual o seu comportamento ?

19 - O que são propriedades ?

20 - Qual a diferença entre campos e propriedades ?

21 - O que é uma struct ?

22 - Qual a diferença entre uma struct e uma classe ?

23 - O que é uma Enum ?

24 - Quais são e qual o escopo dos modificadores de acesso ?

25 - Qual a regra geral para usar os modificadores de acesso ?

26 - Defina partial class ?
 
 */

/*
 
 1 - Uma classe é um modelo que define um tipo de objeto. Ela é composta por campos, propriedades, métodos, eventos e outros elementos de programação.

 2 - Um objeto é uma instância de determinada classe. É criado usando o operador new, seguido do nome da classe.

 3 - Enquanto a classe é um modelo(base) o objeto é uma instância da classe, ou seja, ele tem valores próprios, como na classe carro, onde cada objeto tem uma modelo e 
 etc

 4 - Um método é um bloco que código que executa uma tarefa específica. Ele é criado dentro de uma classe e pode ser chamado a partir de um objeto ou até mesmo pela 
 própria classe.

 5 - Um parâmetro de método é uma variável que recebe um valor que é passado para o método quando ele é chamado.

 6 - Um argumento é um valor que é passado para um método quando ele é chamado.

 7 - Um construtor é um método especial que é chamado quando um objeto é criado. Ele é usado para inicializar o objeto.

 8 - A palavra-chave this é usada para referenciar o objeto atual, podemos usar para chamar métodos, propriedades e campos do objeto atual, boa prática usar this
     para se referir a propriedades e campos do objeto atual. Pode ser usado para chamar um construtor de outra sobrecarga.

 9 - Um método com retorno é um método que retorna um valor. O tipo de retorno é especificado na declaração do método.

 10 - Sobrecarga de método é a capacidade de ter vários métodos com o mesmo nome, mas com parâmetros diferentes, desde o nome, ordem e tipos do parâmetros.

 11 - Na passagem de parâmetros por valor, é feita uma cópia do valor do argumento para o parâmetro do método. Qualquer alteração feita no parâmetro não afeta o 
 argumento.

 12 - Na passagem de parâmetros por referência, é passado o endereço de memória do argumento para o parâmetro do método. Qualquer alteração feita no parâmetro afeta 
 o argumento.

 13 - O parâmetro ref é usado para passar um argumento por referência. O parâmetro out é semelhante ao ref, mas é usado para retornar um valor.

 14 - Argumentos nomeados são argumentos que são passados para um método com o nome do parâmetro correspondente. Isso permite passar os argumentos em qualquer ordem.

 15 - Parâmetros opcionais são parâmetros que têm um valor padrão. Isso significa que eles não precisam ser passados quando o método é chamado.

 16 - A palavra-chave static é usada para declarar membros de uma classe que pertencem à classe em si, e não a um objeto específico.

 17 - Um método estático é um método que pertence à classe em si, e não a um objeto específico. Ele pode ser chamado diretamente a partir do nome da classe.

 18 - Um campo estático é um campo que pertence à classe em si, e não a um objeto específico. Ele é compartilhado por todos os objetos da classe, tendo o mesmo valor 
 para todas as classes

 19 - Propriedades são basicamente campos, porém com métodos de acesso (get e set) que permitem controlar o acesso aos campos da classe.

 20 - A diferença entre campos e propriedades é que as propriedades permitem controlar o acesso aos campos da classe, enquanto os campos são apenas variáveis que 
 armazenam valores.

 21 - Uma struct é um tipo de valor que pode conter campos, propriedades, métodos, eventos e outros elementos de programação. Ela é semelhante a uma classe, mas é 
 um tipo de valor.

 22 - A diferença entre uma struct e uma classe é que uma struct é um tipo de valor, enquanto uma classe é um tipo de referência. Isso significa que uma struct é 
 armazenada na pilha, enquanto uma classe é armazenada no heap.

 23 - Uma Enum é um tipo de valor que é usado para representar um conjunto de constantes nomeadas. Ela é usada para definir um tipo de dados com um número limitado de 
 valores possíveis.

 24 - Os modificadores de acesso são public, private, protected e internal. Public permite que o membro seja acessado de qualquer lugar. Private permite que o membro 
 seja acessado apenas dentro da classe. Protected permite que o membro seja acessado dentro da classe e de classes derivadas. Internal permite que o membro seja acessado
 apenas dentro do mesmo assembly.

 25 - A regra geral para usar os modificadores de acesso é usar o modificador mais restritivo possível. Isso significa que devemos usar private sempre que possível

 26 - Uma partial class (classe parcial) na linguagem C# é uma forma de dividir a definição de uma classe em múltiplos arquivos. Uma classe parcial permite que você 
 declare a implementação de uma classe em partes separadas, em arquivos distintos, mas que, quando compilados, são tratados como uma única classe pelo compilador.
 
 */
