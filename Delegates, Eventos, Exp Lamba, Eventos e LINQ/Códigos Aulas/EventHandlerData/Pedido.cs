namespace EventHandlerArgs;

public class Pedido{

    public event EventHandler<PedidoEventArgs> OnCriarPedido;

    public void CriarPedido(string email, string telefone){

        Console.WriteLine("Pedido Criado\n");

        if(OnCriarPedido != null){
            OnCriarPedido(this, new PedidoEventArgs { Email = email, Telefone = telefone});
        }

    }

}
