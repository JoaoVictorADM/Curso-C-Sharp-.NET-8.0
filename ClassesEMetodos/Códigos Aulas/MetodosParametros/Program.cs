Console.WriteLine("## Métodos com parâmetros ##\n");

MinhaClasse mc = new();

mc.emitirSaudacao("João", DateTime.Now.ToShortDateString());


//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

Aluno a1 = new();
Aluno a2 = new();

a1.nome = "João";
a1.idade = 20;
a1.sexo = "M";
a1.aprovado = "S";

a2.nome = "Maria";
a2.idade = 19;
a2.sexo = "F";
a2.aprovado = "N";

Curso c = new();

c.emitirResultado(a1);
c.emitirResultado(a2);


public class MinhaClasse{

    public void emitirSaudacao(string nome, string data)
    {
        Console.WriteLine($"Bem Vindo {nome}!\n{data}\n");
    }

}

public class Aluno{

    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovado;

}

public class Curso{

    public void emitirResultado(Aluno aluno){

        Console.Write($"O aluno {aluno.nome}, sexo {aluno.sexo} com {aluno.idade} anos");

        if(aluno.aprovado == "S")
            Console.WriteLine(" foi aprovado!\n");
        else
            Console.WriteLine(" foi reprovado!\n");

    }

}


