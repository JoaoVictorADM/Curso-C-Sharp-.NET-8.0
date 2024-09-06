Console.WriteLine("## Métodos ##\n");

MinhaClasse mc = new();

mc.emitirSaudacao();
mc.exibirDataAtual();
mc.exibirDataAtualLonga();

class MinhaClasse{

    public void emitirSaudacao(){
        Console.WriteLine("Bem Vindo!");
        this.exibirDataAtual();
    }

    public void exibirDataAtual(){
        Console.WriteLine($"Data Atual: {DateTime.Now.ToShortDateString()}\n");
    }
    public void exibirDataAtualLonga() =>
        Console.WriteLine($"Data Atual: {DateTime.Now}\n");
    
}
