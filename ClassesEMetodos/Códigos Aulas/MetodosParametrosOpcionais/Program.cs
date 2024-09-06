Console.WriteLine("## Parâmetros opcionais ##\n");

Console.WriteLine("Informe o destino");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto");
var assunto = Console.ReadLine();

Email e = new();
e.enviar();
e.enviar(destino);
e.enviar(destino, titulo);
e.enviar(destino, titulo, assunto);

//não posso fazer
//email.Enviar(destino, , assunto); //causa um erro, preciso usar argumentos nomeados

e.enviar(destino, assunto: assunto);

Console.ReadKey();

public class Email{
    public void enviar(string destino = "Destino padrão", string titulo = "Titulo Padrão", string assunto = "Assunto Padrão"){
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}