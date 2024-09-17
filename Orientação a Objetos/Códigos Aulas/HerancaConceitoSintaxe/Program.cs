Console.WriteLine("## Herança ##\n");

Funcionario f = new();

f.Nome = "João";
f.Email = "@exemplo.com";
f.Empresa = "Empresa";
f.Salario = 1000.0m;

f.Identificar();

Aluno a = new();

a.Nome = "Maria";
a.Email = "@exemplo.com";
a.Curso = "Curso";
a.Nota = 10;

a.Identificar();

public class Pessoa{

    public string? Nome { get; set; }
    public string? Email { get; set; }

    public void Identificar(){
        Console.WriteLine($"{this.Nome} - {this.Email}");
    }

}

public class Funcionario : Pessoa{

    public string? Empresa { get; set; }
    public decimal Salario { get; set; }

    public void Identificar(){
        base.Identificar();
        Console.WriteLine("Funcionario");
    }

}

public class Aluno : Pessoa{

    public string? Curso { get; set; }
    public int Nota { get; set; }
    
    public void Identificar(){
        base.Identificar();
        Console.WriteLine("Aluno");
    }

}