/*
 
w3 - Crie uma struct chamada Cliente e defina os campos Nome e Email do tipo string e a propriedade Idade
do tipo int

w4 - Validar a informação da Idade de forma que se a idade informada for menor que 18 seja atribuído 18 ao
valor da idade.

w5 - Crie um construtor para a struct usando os campos Nome e Email e a propriedade Idade como parâmetros
de entrada para criar um objeto do tipo Cliente

w6 - Crie um método estático que retorne void chamado ExibirInfo que receba os parâmetros nome, email e
idade e exiba as informações de Nome, Email e Idade. Defina idade como um parâmetro opcional.

w7 - Crie um objeto cliente da struct Cliente usando o construtor criado e exiba as informações chamando duas
vezes o método ExibirInfo usando argumentos nomeados. Na primeira chamada informe todos os parâmetros e
na segunda não informe o ano.

w8 - Explique o que uma struct e qual a principal diferença entre struct e classe

 */

Cliente c1 = new("João", "email_generico@gmail.com", 19);

Cliente.exibirInfo(nome: c1.nome, email: c1.email, idade: c1.idade);
Cliente.exibirInfo(nome: c1.nome, email: c1.email);

c1 = new("João", "email_generico@gmail.com", 17);

Cliente.exibirInfo(nome: c1.nome, email: c1.email, idade: c1.idade);
Cliente.exibirInfo(nome: c1.nome, email: c1.email);

/*
 
 A principal diferença entre struct e classe é que struct é um tipo de valor e classe é um tipo de referência.
 
 */

public struct Cliente{

    public string? nome;
    public string? email;
    private int Idade;
    public int idade{ 

        get { return this.Idade; }
        set {
            this.Idade = value < 18 ? 18 : value;
        }
    }

    public Cliente(string? nome, string? email, int idade){
        this.nome = nome;
        this.email = email;
        this.idade = idade;
    }

    public static void exibirInfo(string? nome, string? email, int idade = -1){

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");

        if (idade != -1)
            Console.WriteLine($"Idade: {idade}");

        Console.WriteLine();
    }

}