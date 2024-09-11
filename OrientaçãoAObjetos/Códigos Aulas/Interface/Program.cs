IControle d = new Demo();
d.Nome = "Teste";
d.Desenhar();
d.Exibir();

Console.ReadKey();

interface IControle{
    //public IControle()
    //{}
    //int status;
    void Desenhar();
    string Nome { get; set; }
    public void Exibir(){
        Console.WriteLine("teste...");
    }
}

interface IGrafico{
    void Pintar();
}
public class Demo : IControle, IGrafico{
    public string Nome { get; set; } = string.Empty;

    public void Desenhar(){
        Console.WriteLine("Desenhando..."); ;
    }

    public void Pintar(){
        Console.WriteLine("Pintando...");
    }
}
