namespace EventHandlerArgs;

public class SMS{
    public static void Enviar(object? sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Enviando um SMS para: {e.Telefone}\n");
    }
}
