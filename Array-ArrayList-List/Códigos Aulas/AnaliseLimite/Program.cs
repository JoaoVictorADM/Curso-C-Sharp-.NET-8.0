
var limiteCredito = new List<Limite>();

for(int i = 0; i < 16; i++)
    limiteCredito.Add(new Limite() { Numero = i });

var limitesComRestricao = limiteCredito.Where(x => x.AnalisarLimite()); // Não printa nada, pois nem chama Analisar limite, pois é uma IEnumerable,
                                                                        // só vai ser executado quando for iterado sobre esse IEnumerable
Console.WriteLine("Convertento para list");

limitesComRestricao = limitesComRestricao.ToList(); // Agora sim, ele vai chamar o método AnalisarLimite

public class Limite{

    public int Numero { get; set; }
    private bool isRestricao;

    public Limite(){
        var semente = Guid.NewGuid().GetHashCode();
        var numeroAleatorio = new Random(semente).Next(1, 4);
        isRestricao = numeroAleatorio == 1;
    }

    public bool AnalisarLimite(){
        Console.WriteLine($"Executa análise de limite de Crédito para o limite {this.Numero}");
        return isRestricao;
    }



}