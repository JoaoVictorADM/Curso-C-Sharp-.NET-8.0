namespace EventHandlerArgs;

public class Email{

    public static void Enviar(object? sender, PedidoEventArgs e){
        Console.WriteLine($"Enviando Email para: {e.Email}\n");
    }

}
