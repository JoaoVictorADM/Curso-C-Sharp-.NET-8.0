Console.WriteLine("## This ##");

Teste t1 = new Teste();

t1.num1 = 10;
t1.num2 = 20;
t1.exibir();

Teste t2 = new Teste();
t2.num1 = 88;
t2.num2 = 99;
t2.exibir();


Teste2 t3 = new Teste2(999);

Console.ReadKey();

public class Teste{

    public int num1;
    public int num2;

    public void PassarParametro(Teste t){
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine("Num1: " + t.num1);
        Console.WriteLine("Num2: " + t.num2);
    }

    public void exibir(){
        // passando this como um parâmetro (a classe Teste)
        PassarParametro(this);
    }
}

public class Teste2
{
    public Teste2(int num1, int num2){
        Console.WriteLine($"\nConstrutor com dois parâmetros {num1} e {num2}");
    }

    public Teste2(int num) : this(777, 888){
        Console.WriteLine("\nConstrutor com um parâmetro " + num);
    }
}

public class Cliente{

    public string? nome;
    public int idade;

    public Cliente(string? Nome, int Idade)
    {
        this.nome = Nome;
        this.idade = Idade;
    }
}