Console.WriteLine("## Assinatura de método - Sobrecarga ##\n");

Email e = new();

e.enviar("empresa.com.br");
e.enviar("empresa.com.br", "Proposta Comercial");
e.enviar("empresa.com.br", 2000);
e.enviar(2000, "empresa.com.br");

public class Email{

    public void enviar(string endereco){
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto Padrão");
    }

    public void enviar(string endereco, string assunto){
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}");
    }

    public void enviar(string endereco, decimal valor){
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta Comercial");
        Console.WriteLine($"{valor}");
    }

    public void enviar(decimal valor, string endereco){
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }

}
