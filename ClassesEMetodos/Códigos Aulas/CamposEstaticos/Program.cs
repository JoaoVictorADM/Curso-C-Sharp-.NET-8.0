Console.WriteLine("## Campos estáticos - Exercício ##\n");

ContaCorrente c1 = new ContaCorrente();
c1.conta = 101;
c1.nome = "Maria";
//c1.Juros = 3.99f;

ContaCorrente c2 = new ContaCorrente();
c2.conta = 102;
c2.nome = "Marta";
//c2.Juros = 4.99f;

ContaCorrente.juros = 4.25f;

Console.WriteLine($"Cliente : {c1.nome} - Juros Anual : {c1.jurosAnual()}");
Console.WriteLine($"Cliente : {c2.nome} - Juros Anual : {c2.jurosAnual()}");

Console.ReadKey();

public class ContaCorrente{
    public int conta;
    public string? nome;
    public static float juros;

    public float jurosAnual(){
        return juros * 12;
    }
}