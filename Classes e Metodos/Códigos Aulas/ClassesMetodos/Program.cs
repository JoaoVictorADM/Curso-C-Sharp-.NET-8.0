Console.WriteLine("## Classes e Métodos ##\n");

int x = 100;

Pessoa p1 = new Pessoa();
Pessoa p2 = new();

p1.nome = "João";
p1.idade = 20;
p1.sexo = "M";

p2.nome = "Maria";
p2.idade = 19;
p2.sexo = "F";

Console.WriteLine($"P1 - Nome: {p1.nome} - Idade: {p1.idade} - Sexo: {p1.sexo}\n");
Console.WriteLine($"P1 - Nome: {p2.nome} - Idade: {p2.idade} - Sexo: {p2.sexo}\n");

Pessoa p3 = p1;

p3.nome = "José";

Console.WriteLine($"P1 - Nome: {p1.nome} - Idade: {p1.idade} - Sexo: {p1.sexo}\n");

var p4 = new Pessoa();

public class Pessoa{

    public string? nome;
    public int idade;
    public string? sexo;

}
