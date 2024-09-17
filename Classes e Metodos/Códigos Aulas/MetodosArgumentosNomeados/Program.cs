Console.WriteLine("## Argumentos nomeados ##\n");

Email e = new();

e.enviar("teste@email.com", "Reunião de Orçamento", "Urgente");

//argumentos nomeados
e.enviar(titulo: "Urgente", destino: "teste@email.com", assunto: "Reunião Orçamento");
e.enviar(destino: "teste@email.com", assunto: "Reunião Orçamento", titulo: "Urgente");
e.enviar(assunto: "Reunião Orçamento", titulo: "Urgente", destino: "teste@email.com");


Console.ReadKey();

public class Email{

    public void enviar(string destino, string titulo, string assunto){
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }

}